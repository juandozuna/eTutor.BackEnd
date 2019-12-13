﻿using System;
using System.IO;
using System.Threading.Tasks;
using eTutor.Core.Contracts;
using eTutor.Core.Models.Configuration;
using Firebase.Auth;
using Firebase.Storage;

namespace eTutor.FileHandler
{
    public sealed class FirebaseStorageFileService : IFileService
    {
        private readonly FirebaseConfiguration _firebaseConfiguration;

        public FirebaseStorageFileService(FirebaseConfiguration firebaseConfiguration)
        {
            _firebaseConfiguration = firebaseConfiguration;
        }

        public async Task<string> UploadStreamToBucketServer(Stream file, string fileName)
        {
            string fileExtension = Path.GetExtension(fileName);
            var task = BuildFirebaseStorageObject()
                .Child("files")
                .Child($"{Guid.NewGuid().ToString()}.{fileExtension}")
                .PutAsync(file);
            return await task;
        }

        public Task DeleteFileFromBucketServer(string fileName)
        {
            return BuildFirebaseStorageObject()
                .Child(fileName)
                .DeleteAsync();
        }

        private FirebaseStorage BuildFirebaseStorageObject()
        {
             
            return new FirebaseStorage(_firebaseConfiguration.Bucket, new FirebaseStorageOptions
            {
                AuthTokenAsyncFactory = GetFirebaseAuthenticationToken,
                ThrowOnCancel = true
            });
        }

        private async Task<string> GetFirebaseAuthenticationToken()
        {
            var auth = new FirebaseAuthProvider(new FirebaseConfig(_firebaseConfiguration.ApiKey));
            var signIn = await auth.SignInWithEmailAndPasswordAsync(_firebaseConfiguration.AuthEmail,
                _firebaseConfiguration.AuthPassword);
            var token = signIn.FirebaseToken;
            return token;
        }
    }
}