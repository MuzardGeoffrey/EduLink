import { Routes } from '@angular/router';

export default [
  { path: 'login', loadComponent: () => import('./login/login.component').then(module => module.LoginComponent), title: "Login" },
  { path: 'registration', loadComponent: () => import('./registration/registration.component').then(module => module.RegistrationComponent), title: "Registration" },
] as Routes;
