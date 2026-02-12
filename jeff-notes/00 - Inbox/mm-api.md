# Api Design for the MM Api

## Students / Student

### Adding MM
- Add 1 - 3 MMs to be explored the next day.

- Title (Developer Testing)
- Description (optional, more context for what your looking for)


When I said before lunch "What data do we need to provide the server to process this request"
- I meant "we spent a good part of a 1/2 hour talking about the functionality of this application. - how do we get that? What do we need?"
- Programs are Code (static) and Data (changing). Just saved you 4 years of school.
- Data is used to present "state" - what is the thing *now* (and sometimes at other arbitrary dates and time).
- What data do we need to be able to write the code to enable the functionality we designed?

- features, abbreviated:
    - students: (YOU component)
        - add MM - the collection of YOUR MM
        - edit an MM    -- you can edit one of YOUR MM, but not someone elses
        - remove an MM -- you can remove one of yourse, but not someone elses.
        - see all of their MM -- You can see your list, but not anyone elses.
    - instructor
        - see the aggregated list -- I can see all of them, but I don't know created each one.
        - punt -- I have my own list, basically, that I can put things on to defer them to later.


"Store"

- Documents

    /employees/x99999



- Collections
    /employees

```http
POST https://localhost:1337/student/moments 
Content-Type: application/json
Authorization: Bearer ???? (Fake this for while)

{
    "title": "Containers",
    "description": "Tell me about volumes"
}

```

1. Get of the 404 - 
    - if it is good, something in the range of 200-299.
    - if the user made a bad request, those are 400-499
        - If you don't an authoriztion header that we trust, 401.
        - If I know who are are (you are authenticated), but, seriously, take this personally, YOU cannot do that - 403.
        - 400 - You screwed up.
            - general bad request
    - Any success Status Code - would be 200-299
        - 200 Ok. With a body.


```http
GET https://localhost:1337/student/moments 

```

```http
DELETE https://localhost:1337/student/moments/82c4721b-734e-4c76-911b-e50ef3590b31

```
200 Ok
Content-type: application/json

[
    {
        "id": "8398398",
        "title": "HTTP",
        "description": "More On Resources, plz.",
        "createdAt": "{{timeStamp}}",
        "addedBy": "sue@company.com"
    }

]
``

### Get a list of MM

A student needs a way to see the list of all their submitted MMs

### Remove an MM


### Edit an MM


## Instructor


### Get A List
Can get a list of all the students aggregated moments in a summary form so they can be addressed.


### Punt
Say "I don't want to lose this, but I promise I'll talk about it later"


## In HTTP - we have three things we can "design", and we have to figure out how to map a business process to these threee things.

- Resources - An importantant thingy we want to expose to the consumer of this service. They have names. At least one. And those are URIs.
    - https://mm.hypertheory-labs.dev/api/students/moments
        - the scheme - http | https
        - "mm.hypertheory-labs.dev" - known as the "origin" or sometimes the "authority".
        - /api/students/moments - "the path" (to the thing we want, the resource)



- Representations
    - what are you going to get from a resource, or send to a resource?
        - the web doesn't specify. Can be ANYTHING the client and the server agree on.
        - we are going to do our representations in JSON (a serialization format) 
- Methods 
    - GET, POST, PUT, DELETE

    - GET means "get" - I wanna see it. No "side effects"
    - POST means different things depending on the kind of resource - but on a "collection" resource it means something like:
        "Excuse me ma'am, I'd like you to consider taking this representation I am sending you and making part of your family"

    

