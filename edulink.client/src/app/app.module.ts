import { Routes } from '@angular/router';
import { AuthGuard } from './auth.guard';

export const routes: Routes = [
  { path: '', loadChildren: () => import('./identification/identification.route') },
  { path: 'home', loadComponent: () => import('./home/home.component').then(module => module.HomeComponent), title: "home" },
  { path: 'profile', loadComponent: () => import('./profile/profile.component').then(module => module.ProfileComponent), title: "profile", canActivate: [AuthGuard] },
  { path: '', redirectTo: 'home', pathMatch: 'full' },

];
