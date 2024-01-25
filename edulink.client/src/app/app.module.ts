import { Routes } from '@angular/router';
import { AuthGuard } from './auth.guard';

export const routes: Routes = [
  { path: 'home', loadComponent: () => import('./home/home.component').then(module => module.HomeComponent), title: "home" },
  { path: 'profile', loadComponent: () => import('./profile/profile.component').then(module => module.ProfileComponent), title: "profile",canActivate: [AuthGuard] },
  { path: 'identification', loadChildren: () => import('./identification/identification.route') },
  { path: '', redirectTo: 'home', pathMatch: 'full' },

];
