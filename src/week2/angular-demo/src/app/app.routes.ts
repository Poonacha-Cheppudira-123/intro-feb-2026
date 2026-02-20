import { Routes } from '@angular/router';
import { About } from './pages/about';
import { Profile } from './pages/profile';
import { Home } from './pages/home';

export const routes: Routes = [
  {
    path: 'about',
    component: About,
  },
  {
    path: 'profile',
    component: Profile,
  },
  {
    path: 'questions',
    loadChildren: () => import('./areas/questions/questions.routes').then((m) => m.QuestionRoutes),
  },
  {
    path: '',
    component: Home,
  },
  {
    path: 'basics',
    loadChildren: () => import('./areas/basics/basics.routes').then((m) => m.BasicsRoutes),
  },
];
