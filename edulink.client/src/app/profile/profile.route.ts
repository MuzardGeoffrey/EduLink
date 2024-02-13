import { Routes } from '@angular/router';

export default [
  { path: 'detail', loadComponent: () => import('./detail-profile/detail-profile.component').then(module => module.DetailProfileComponent), title: "Detail" },
  { path: 'edit', loadComponent: () => import('./edit-profile/edit-profile.component').then(module => module.EditProfileComponent), title: "Edit" }
] as Routes;
