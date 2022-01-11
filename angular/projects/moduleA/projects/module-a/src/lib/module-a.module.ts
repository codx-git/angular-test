import { NgModule, NgModuleFactory, ModuleWithProviders } from '@angular/core';
import { CoreModule, LazyModuleFactory } from '@abp/ng.core';
import { ThemeSharedModule } from '@abp/ng.theme.shared';
import { moduleAComponent } from './components/module-a.component';
import { moduleARoutingModule } from './module-a-routing.module';

@NgModule({
  declarations: [moduleAComponent],
  imports: [CoreModule, ThemeSharedModule, moduleARoutingModule],
  exports: [moduleAComponent],
})
export class moduleAModule {
  static forChild(): ModuleWithProviders<moduleAModule> {
    return {
      ngModule: moduleAModule,
      providers: [],
    };
  }

  static forLazy(): NgModuleFactory<moduleAModule> {
    return new LazyModuleFactory(moduleAModule.forChild());
  }
}
