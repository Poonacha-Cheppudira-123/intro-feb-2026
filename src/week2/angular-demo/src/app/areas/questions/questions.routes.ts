import { Routes } from '@angular/router';
import { Questions } from './questions';
import { List } from './pages/list';
import { Ask } from './pages/ask';
import { QuestionStore } from './question-store';
export const QuestionRoutes: Routes = [
  {
    path: '',
    component: Questions,
    providers: [QuestionStore],
    children: [
      {
        path: '',
        component: List,
      },
      {
        path: 'ask',
        component: Ask,
      },
    ],
  },
];
