import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: false,
  application: {
    baseUrl: 'http://localhost:4200/',
    name: 'moduleA',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44374',
    redirectUri: baseUrl,
    clientId: 'moduleA_App',
    responseType: 'code',
    scope: 'offline_access moduleA role email openid profile',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44374',
      rootNamespace: 'moduleA',
    },
    moduleA: {
      url: 'https://localhost:44369',
      rootNamespace: 'moduleA',
    },
  },
} as Environment;
