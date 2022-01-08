import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'test',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44393',
    redirectUri: baseUrl,
    clientId: 'test_App',
    responseType: 'code',
    scope: 'offline_access test',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44393',
      rootNamespace: 'mold.test',
    },
  },
} as Environment;
