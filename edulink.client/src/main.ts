/// <reference types="@angular/localize" />

import { routes } from './app/app.module';
import { importProvidersFrom } from '@angular/core';
import { AppComponent } from './app/app.component';
import { provideRouter } from '@angular/router';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { withInterceptorsFromDi, provideHttpClient } from '@angular/common/http';
import { BrowserModule, bootstrapApplication } from '@angular/platform-browser';


bootstrapApplication(AppComponent, {
    providers: [
        importProvidersFrom(BrowserModule, FormsModule, ReactiveFormsModule),
        provideHttpClient(withInterceptorsFromDi()),
        provideRouter(routes)
    ]
})
  .catch(err => console.error(err));
