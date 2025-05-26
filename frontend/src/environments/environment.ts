export const environment = {
    production: false,
    appName: 'AuthApp - Angular Authentication - DEV',

    // api
    apiBaseUrl: 'http://localhost:5000/api',

    // api auth
    apiRefreshTokenEndpoint: '/auth/refresh-token',
    apiSignInEndpoint: '/auth/signin',
    apiSignOutEndpoint: '/auth/signout',
    apiSignUpEndpoint: '/auth/signup',

    // api user
    apiUserProfileEndpoint: '/user/profile',
    apiUserUpdateEndpoint: '/user/update',
    apiUserDeleteEndpoint: '/user/delete',
    
    // localstorage keys
    tokenKey: 'token',
    refreshKey: 'refresh_token',
    userKey: 'user',
  };
  