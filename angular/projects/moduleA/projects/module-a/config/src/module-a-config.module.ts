import { ModuleWithProviders, NgModule } from '@angular/core';
import { MODULE_A_ROUTE_PROVIDERS } from './providers/route.provider';

@NgModule()
export class moduleAConfigModule {
  static forRoot(): ModuleWithProviders<moduleAConfigModule> {
    return {
      ngModule: moduleAConfigModule,
      providers: [MODULE_A_ROUTE_PROVIDERS],
    };
  }
}
