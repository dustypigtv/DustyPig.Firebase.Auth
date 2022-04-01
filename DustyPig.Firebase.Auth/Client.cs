/*
    Documentation: https://firebase.google.com/docs/reference/rest/auth 
*/
using DustyPig.Firebase.Auth.Models;
using DustyPig.REST;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace DustyPig.Firebase.Auth
{
    public class Client
    {
        private const string URL_BASE = "https://identitytoolkit.googleapis.com";

        private const string URL_SIGNIN_WITH_CUSTOM_TOKEN = "/v1/accounts:signInWithCustomToken";
        private const string URL_REFRESH_TOKEN = "/v1/token";
        private const string URL_SIGNUP = "/v1/accounts:signUp";
        private const string URL_SIGNIN_WITH_PASSWORD = "/v1/accounts:signInWithPassword";
        private const string URL_SIGNIN_WITH_IDP = "/v1/accounts:signInWithIdp";
        private const string URL_CREATE_AUTH_URI = "/v1/accounts:createAuthUri";
        private const string URL_SEND_OOB_CODE = "/v1/accounts:sendOobCode";
        private const string URL_RESET_PASSWORD = "/v1/accounts:resetPassword";
        private const string URL_UPDATE = "/v1/accounts:update";
        private const string URL_LOOKUP = "/v1/accounts:lookup";
        private const string URL_DELETE = "/v1/accounts:delete";

        private static readonly REST.Client _client = new REST.Client() { BaseAddress = new Uri(URL_BASE) };

        public Client() { }

        public Client(string key) => Key = key;

        


        public string Key { get; set; }





        // These 3 helper methods just add the api key and the X-Firebase-Locale header

        private Task<Response<T>> PostDataAsync<T>(string url, object data, CancellationToken cancellationToken)
            => _client.PostWithResponseDataAsync<T>(url + "?key=" + Key, data, cancellationToken);


        private Task<Response<T>> PostDataAsync<T>(string url, string firebaseLocaleHeader, object data, CancellationToken cancellationToken)
        {
            _client.DefaultRequestHeaders.Clear();
            if (!string.IsNullOrWhiteSpace(firebaseLocaleHeader))
                _client.DefaultRequestHeaders.Add("X-Firebase-Locale", firebaseLocaleHeader);
            return PostDataAsync<T>(url + "?key=" + Key, data, cancellationToken);
        }


        private Task<Response> PostDataAsync(string url, object data, CancellationToken cancellationToken)
            => _client.PostAsync(url + "?key=" + Key, data, cancellationToken);








        /// <summary>
        /// Exchange custom token for an ID and refresh token
        /// </summary>
        /// <param name="token">A Firebase Auth custom token from which to create an ID and refresh token pair.</param>
        public Task<Response<SignInWithCustomToken>> SignInWithCustomTokenAsync(string token, CancellationToken cancellationToken = default) =>
            PostDataAsync<SignInWithCustomToken>(URL_SIGNIN_WITH_CUSTOM_TOKEN, new SignInWithCustomTokenRequest { Token = token }, cancellationToken);



        /// <summary>
        /// Exchange a refresh token for an ID token
        /// </summary>
        /// <param name="refresh_token">A Firebase Auth refresh token.</param>
        public Task<Response<RefreshToken>> RefreshTokenAsync(string refresh_token, CancellationToken cancellationToken = default) =>
            PostDataAsync<RefreshToken>(URL_REFRESH_TOKEN, new RefreshTokenRequest { RefreshToken = refresh_token }, cancellationToken);



        /// <summary>
        /// Sign up with email / password
        /// </summary>
        /// <param name="email">The email for the user to create.</param>
        /// <param name="password">The password for the user to create.</param>
        public Task<Response<SignUpWithEmailPassword>> SignUpWithEmailPasswordAsync(string email, string password, CancellationToken cancellationToken = default) =>
            PostDataAsync<SignUpWithEmailPassword>(URL_SIGNUP, new EmailPasswordRequest
            {
                Email = email,
                Password = password
            }, cancellationToken);



        /// <summary>
        /// Sign in with email / password
        /// </summary>
        /// <param name="email">The email the user is signing in with.</param>
        /// <param name="password">The password for the account.</param>
        public Task<Response<SignInWithEmailPassword>> SignInWithEmailPasswordAsync(string email, string password, CancellationToken cancellationToken = default) =>
            PostDataAsync<SignInWithEmailPassword>(URL_SIGNIN_WITH_PASSWORD, new EmailPasswordRequest
            {
                Email = email,
                Password = password
            }, cancellationToken);



        /// <summary>
        /// Sign in anonymously
        /// </summary>
        public Task<Response<SignInAnonymously>> SignInAnonymouslyAsync(CancellationToken cancellationToken = default) =>
            PostDataAsync<SignInAnonymously>(URL_SIGNUP, new SignInAnonymouslyRequest(), cancellationToken);



        /// <summary>
        /// Sign in with OAuth credential
        /// </summary>
        /// <param name="requestUri">The URI to which the IDP redirects the user back.</param>
        /// <param name="idToken">The OAuth credential (an ID token or access token).</param>
        /// <param name="providerId">The Provider Id which issues the credential.</param>
        /// <param name="returnIdpCredential">Whether to force the return of the OAuth credential on the following errors: FEDERATED_USER_ID_ALREADY_LINKED and EMAIL_EXISTS.</param>
        public Task<Response<SignInWithOAuth>> SignInWithOAuthAsync(string requestUri, string idToken, string providerId, bool returnIdpCredential = false, CancellationToken cancellationToken = default) =>
            PostDataAsync<SignInWithOAuth>(URL_SIGNIN_WITH_IDP, new SignInWithOAuthRequest
            {
                PostBody = $"id_token={idToken}&providerId={providerId}",
                RequestUri = requestUri,
                ReturnIdpCredential = returnIdpCredential
            }, cancellationToken);



        /// <summary>
        /// Fetch providers for email
        /// </summary>
        /// <param name="identifier">User's email address</param>
        /// <param name="continueUri">The URI to which the IDP redirects the user back. For this use case, this is just the current URL.</param>
        public Task<Response<FetchProvidersForEmail>> FetchProvidersForEmailAsync(string identifier, string continueUri, CancellationToken cancellationToken = default) =>
            PostDataAsync<FetchProvidersForEmail>(URL_CREATE_AUTH_URI, new FetchProvidersForEmailRequest
            {
                ContinueUri = continueUri,
                Identifier = identifier
            }, cancellationToken);



        /// <summary>
        /// Send password reset email
        /// </summary>
        /// <param name="email">User's email address.</param>
        /// <param name="xFirebaseLocale">The optional language code corresponding to the user's locale. Passing this will localize the password reset email sent to the user.</param>
        public Task<Response<SendEmail>> SendPasswordResetEmailAsync(string email, string xFirebaseLocale = null, CancellationToken cancellationToken = default) =>
            PostDataAsync<SendEmail>(URL_SEND_OOB_CODE, xFirebaseLocale, new SendPasswordResetEmailRequest { Email = email }, cancellationToken);



        /// <summary>
        /// Verify password reset code
        /// </summary>
        /// <param name="oobCode">The email action code sent to the user's email for resetting the password.</param>
        public Task<Response<PasswordReset>> VerifyPasswordResetCodeAsync(string oobCode, CancellationToken cancellationToken = default) =>
            PostDataAsync<PasswordReset>(URL_RESET_PASSWORD, new OOBRequest { OOBCode = oobCode }, cancellationToken);



        /// <summary>
        /// Confirm password reset
        /// </summary>
        /// <param name="oobCode">The email action code sent to the user's email for resetting the password.</param>
        /// <param name="newPassword">The user's new password.</param>
        public Task<Response<PasswordReset>> ConfirmPasswordResetAsync(string oobCode, string newPassword, CancellationToken cancellationToken = default) =>
            PostDataAsync<PasswordReset>(URL_RESET_PASSWORD, new ConfirmPasswordResetRequest
            {
                OOBCode = oobCode,
                NewPassword = newPassword
            }, cancellationToken);



        /// <summary>
        /// Change email
        /// </summary>
        /// <param name="idToken">A Firebase Auth ID token for the user.</param>
        /// <param name="email">The user's new email.</param>
        /// <param name="returnSecureToken">Whether or not to return an ID and refresh token.</param>
        /// <param name="xFirebaseLocale">The optional language code corresponding to the user's locale. Passing this will localize the email change revocation sent to the user.</param>
        public Task<Response<ChangeEmailPassword>> ChangeEmailAsync(string idToken, string email, bool returnSecureToken = false, string xFirebaseLocale = null, CancellationToken cancellationToken = default) =>
            PostDataAsync<ChangeEmailPassword>(URL_UPDATE, xFirebaseLocale, new ChangeEmailRequest
            {
                IdToken = idToken,
                Email = email,
                ReturnSecureToken = returnSecureToken
            }, cancellationToken);



        /// <summary>
        /// Change password
        /// </summary>
        /// <param name="idToken">A Firebase Auth ID token for the user.</param>
        /// <param name="password">User's new password.</param>
        /// <param name="returnSecureToken">Whether or not to return an ID and refresh token.</param>
        public Task<Response<ChangeEmailPassword>> ChangePasswordAsync(string idToken, string password, bool returnSecureToken = false, CancellationToken cancellationToken = default) =>
            PostDataAsync<ChangeEmailPassword>(URL_UPDATE, new ChangePasswordRequest
            {
                IdToken = idToken,
                Password = password,
                returnSecureToken = returnSecureToken
            }, cancellationToken);



        /// <summary>
        /// Update Profile
        /// </summary>
        /// <param name="idToken">A Firebase Auth ID token for the user.</param>
        /// <param name="displayName">User's new display name.</param>
        /// <param name="photoUrl">User's new photo url.</param>
        /// <param name="returnSecureToken">Whether or not to return an ID and refresh token.</param>
        public Task<Response<UpdateProfile>> UpdateProfileAsync(string idToken, string displayName, string photoUrl, bool returnSecureToken = false, CancellationToken cancellationToken = default)
        {
            var request = new UpdateProfileRequest
            {
                IdToken = idToken,
                DisplayName = displayName,
                PhotoUrl = photoUrl,
                ReturnSecureToken = returnSecureToken
            };

            if (string.IsNullOrWhiteSpace(displayName))
            {
                request.DisplayName = null;
                request.DeleteAttributes = new List<string> { "DISPLAY_NAME" };
            }

            if (string.IsNullOrWhiteSpace(photoUrl))
            {
                request.PhotoUrl = null;
                if (request.DeleteAttributes == null)
                    request.DeleteAttributes = new List<string>();
                request.DeleteAttributes.Add("PHOTO_URL");
            }

            return PostDataAsync<UpdateProfile>(URL_UPDATE, request, cancellationToken);
        }



        /// <summary>
        /// Get user data
        /// </summary>
        /// <param name="idToken">The Firebase ID token of the account.</param>
        public Task<Response<GetUserData>> GetUserDataAsync(string idToken, CancellationToken cancellationToken = default) =>
            PostDataAsync<GetUserData>(URL_LOOKUP, new IdTokenRequest { IdToken = idToken }, cancellationToken);



        /// <summary>
        /// Link with email/password
        /// </summary>
        /// <param name="idToken">The Firebase ID token of the account you are trying to link the credential to.</param>
        /// <param name="email">The email to link to the account.</param>
        /// <param name="password">The new password of the account.</param>
        public Task<Response<LinkWithEmailPassword>> LinkWithEmailPasswordAsync(string idToken, string email, string password, CancellationToken cancellationToken = default) =>
            PostDataAsync<LinkWithEmailPassword>(URL_UPDATE, new LinkWithEmailPasswordRequest
            {
                IdToken = idToken,
                Email = email,
                Password = password
            }, cancellationToken);





        /// <summary>
        /// Link with OAuth credential
        /// </summary>
        /// <param name="idToken">The Firebase ID token of the account you are trying to link the credential to.</param>
        /// <param name="requestUri">The URI to which the IDP redirects the user back.</param>
        /// <param name="oauthToken">The OAuth credential (an ID token or access token).</param>
        /// <param name="providerId">The provider ID which issues the credential.</param>
        /// <param name="returnIdpCredential">Whether to force the return of the OAuth credential on the following errors: FEDERATED_USER_ID_ALREADY_LINKED and EMAIL_EXISTS.</param>
        public Task<Response<LinkWithOAuth>> LinkWithOAuthAsync(string idToken, string requestUri, string oauthToken, string providerId, bool returnIdpCredential = false, CancellationToken cancellationToken = default) =>
            PostDataAsync<LinkWithOAuth>(URL_SIGNIN_WITH_IDP, new LinkWithOAuthRequest
            {
                IdToken = idToken,
                RequestUri = requestUri,
                PostBody = $"id_token={oauthToken}&providerId={providerId}",
                ReturnIdpCredential = returnIdpCredential
            }, cancellationToken);



        /// <summary>
        /// Unlink provider
        /// </summary>
        /// <param name="idToken">The Firebase ID token of the account.</param>
        /// <param name="deleteProviders">The list of provider IDs to unlink, eg: 'google.com', 'password', etc.</param>
        public Task<Response<UnlinkProvider>> UnlinkProviderAsync(string idToken, IEnumerable<string> deleteProviders, CancellationToken cancellationToken = default) =>
            PostDataAsync<UnlinkProvider>(URL_UPDATE, new UnlinkProviderRequest
            {
                IdToken = idToken,
                DeleteProvider = new List<string>(deleteProviders)
            }, cancellationToken);



        /// <summary>
        /// Send email verification
        /// </summary>
        /// <param name="idToken">The Firebase ID token of the user to verify.</param>
        /// <param name="xFirebaseLocale">The optional language code corresponding to the user's locale. Passing this will localize the email verification sent to the user.</param>
        public Task<Response<SendEmail>> SendEmailVerificationAsync(string idToken, string xFirebaseLocale = null, CancellationToken cancellationToken = default) =>
            PostDataAsync<SendEmail>(URL_SEND_OOB_CODE, xFirebaseLocale, new SendEmailVerificationRequest { IdToken = idToken }, cancellationToken);



        /// <summary>
        /// Confirm email verification
        /// </summary>
        /// <param name="oobCode">The action code sent to user's email for email verification.</param>
        public Task<Response<ConfirmEmailVerification>> ConfirmEmailVerificationAsync(string oobCode, CancellationToken cancellationToken = default) =>
            PostDataAsync<ConfirmEmailVerification>(URL_UPDATE, new OOBRequest { OOBCode = oobCode }, cancellationToken);



        /// <summary>
        /// Delete account
        /// </summary>
        /// <param name="idToken">The Firebase ID token of the user to delete.</param>
        public Task<Response> DeleteAccountAsync(string idToken, CancellationToken cancellationToken = default) =>
            PostDataAsync(URL_DELETE, new IdTokenRequest { IdToken = idToken }, cancellationToken);


    }
}
