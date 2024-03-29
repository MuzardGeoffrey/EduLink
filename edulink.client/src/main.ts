/// <reference types="@angular/localize" />

import { routes } from './app/app.module';
import { importProvidersFrom } from '@angular/core';
import { AppComponent } from './app/app.component';
import { provideRouter } from '@angular/router';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { withInterceptorsFromDi, provideHttpClient } from '@angular/common/http';
import { BrowserModule, bootstrapApplication } from '@angular/platform-browser';
import { FooterComponent } from './app/shared/footer/footer.component';
import { provideAnimations } from '@angular/platform-browser/animations';
import { MatMenuTrigger } from '@angular/material/menu';

bootstrapApplication(AppComponent, {
  providers: [
    importProvidersFrom(BrowserModule, FormsModule, ReactiveFormsModule, MatMenuTrigger),
    provideHttpClient(withInterceptorsFromDi()),
    provideRouter(routes),
    FooterComponent,
    provideAnimations()
  ]
})
  .catch(err => console.error(err));
