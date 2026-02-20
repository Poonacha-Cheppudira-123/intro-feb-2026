import { delay, http, HttpResponse } from 'msw';

const fakeQuestions = [
  {
    id: '1',
    title: 'Upgrading My Angular App??',
    content: "I have an Angular 17 app, and I want to upgrade to Angular 20. What's the process.",
  },
  {
    id: '2',
    title: 'Angular vs React',
    content: 'Which one is better for building web applications?',
    submittedAnswers: [
      {
        id: 'a1',
        content:
          'Angular is better for large-scale applications, while React is more flexible for smaller projects.',
      },
      {
        id: 'a2',
        content: 'React has a larger community and more third-party libraries available.',
      },
    ],
  },
];

export default [
  //   http.get('/api/questions', async () => {
  //     await delay();
  //     return HttpResponse.json(fakeQuestions);
  //   }),
];
