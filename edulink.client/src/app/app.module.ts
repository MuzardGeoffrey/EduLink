import { Routes } from '@angular/router';
import { AuthGuard } from './auth.guard';

export const routes: Routes = [
  { path: 'identication', loadChildren: () => import('./identification/identification.route') },
  {
    path: 'profile', loadChildren: () => import('./profile/profile.route'), canActivate: [AuthGuard]
  },
  { path: 'home', loadComponent: () => import('./home/home.component').then(module => module.HomeComponent), title: "home" },
  { path: '', redirectTo: 'home', pathMatch: 'full' },

];
