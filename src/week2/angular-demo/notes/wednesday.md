# Wednesday


# Wednesday


## MSW

```sh
npm i -D msw
npx msw init public --save
```

## `src/app/__mocks__/browser.ts`

```ts
import { setupWorker } from 'msw/browser';
import { handlers } from './handlers';
export const worker = setupWorker(...handlers);
```

## `src/app/__mocks__/handler.ts`

```ts
import { HttpHandler } from 'msw';

export const handlers: HttpHandler[] = [];
```

## `src/main.ts`

```ts
import { bootstrapApplication } from '@angular/platform-browser';
import { appConfig } from './app/app.config';
import { App } from './app/app';
import { isDevMode } from '@angular/core';

async function enableMocking() {
  if (isDevMode()) {
    const { worker } = await import('./app/__mocks__/browser');
    console.info('Starting the mock service worker since you are in development mode.');
    return await worker.start({
      quiet: true, // be quiet. don't log out a bunch of stuff to the console.
      onUnhandledRequest: 'bypass', // if I don't have fake handler, just really send the request.
    });
  }
  return;
}
enableMocking().then(() => bootstrapApplication(App, appConfig).catch((err) => console.error(err)));
```

I 


