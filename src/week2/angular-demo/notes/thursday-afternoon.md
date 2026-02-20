
# Api Type Generation

Install  @hey-api/openapi-ts

```sh
npm i -D @hey-api/openapi-ts
```

The `openapi-ts.config.ts` file:

```ts
import { defineConfig } from '@hey-api/openapi-ts';

export default defineConfig({
  input: ['./open-api-specs/specification.json'],
  output: [
    {
      path: 'src/app/areas/shared/api/',
      postProcess: ['prettier', 'eslint'],
    },
  ],
  plugins: [
    'zod',
    {
      name: '@hey-api/client-angular',
      throwOnError: true,
      bundle: false,
    },
  ],
});
```


Add a script:

`openapi-ts`


```http
POST https://localhost:9300/questions 
Content-Type: application/json

{
  "title": "Such a Question!",
  "content": "I have so many questions"
}

```


```http
GET https://localhost:9300/questions 
```
