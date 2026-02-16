# Week 1 Review - or "Whatever *that* was!"

Here are some key things I'd like for you to remember and/or ponder coming out of week one of this course. We covered a lot - and sometimes it may have seemed to be really confusing and "all over the place". We can attribute *some* of that to the instructor, but it's also the nature of modern software development. Everything is sort of layers of technology stacked upon other layers of technology, and the same with the concepts behind all of those layers. 

I'd never say this stuff all *ever* gets particularly easy or intuitive, but with repeated visits to the depths of all this stuff, eventually you start building a conceptual map. In the beginning, everything seems brand-new, novel. Like, imagining a world where you are being taught the English alphabet. You have a few days being introduced to the letter "A". You *almost* have it down, and then the teacher moves on to a totally different topic - what the heck is this "B" thing? Except this stuff is, well, actually complex (meaning made up of lots of different, interweaving concepts and technologies) and it can feel very overwhelming.

## Timeline of the Week

### Monday and Tuesday
After our introductions, etc. we started by jumping into the deep end. "Sure, many of you have never seen Visual Studio before, you may not know C#, but let's build one of the most complicated things there are - A highly concurrent, multi-threaded HTTP-based API." 

Why would the instructor (yours truly) do such a sadistic thing? 

- I assume you've already had the warm and friendly "let's write a 'Hello, World!' application". You understand at least the foundations of software and software development.
- In your job here, nobody is going to give you a "hello, world!" application to work on. You will begin by making small contributions to large projects that you won't entirely understand. There are some projects and code bases at your company that *nobody* understands completely. As a matter of fact, the inability for one person to hold complex systems in their heads was the thing that initiated what could be called the beginning of the modern software development era. 

What you need to know, when working in systems like that are many things, but generally the high level stuff is:

  - What *kind* (e.g. category) of software is this system?
  - How is the code that I work on or contribute integrated into this system? How does it actually get executed? What is the *context* in which it will run?
  
So, in week 1, we looked at *one* particular category of software out of many. And this was a "service". 

- A service is some code (a "code module") that provides functionality to other code. You could say it "owns" some part of the business or technical operation of the company. The team that writes, maintains, and expands that service have a big part of their brains dedicated to that aspect of the company. Identity management, inventory control, bonus calculation, etc. At any large company even something as seemingly "simple" as email communication with our customers often requires a team of experts to navigate. 
- These services have to have some way to expose functionality to other applications. It's no good to have some of the best code in the world for email communication, if nobody can use it. A very common way (but not the only way) to create an "interface" through which other software can communicate and use the functionality of a service (an "Application Programming Interface", or "API") is to use the HTTP protocol. 
  - HTTP is known, ubiquitous, and we have good tooling for it in terms of security, observability, etc.
  - It does assume a networked service. 
    - Contemplation: What is the difference between an HTTP API, for example, and a package you install through NuGet or another package manager? What are the similarities? 
  - It's "good enough" for most scenarios. 
    - It isn't always the best performing - but "good enough" usually.
    - It limits you to really one main communication style (request-response), but *most* tasks can be accomplished this way.
  - In other words, it's a very reasonable default.

Your company has roughly 1 bazillion HTTP services running in production around the world right now. You should invest a little bit of time understanding HTTP, how it works, etc. before you even think about writing some code for one. But I don't really believe that, even though on paper it "looks right". I find for *most* software developers, you have to intermingle writing some code along with the concepts that support that style of coding. What you need to train yourself to do, if you are going to learn that way (which you will, sort of whether you like it or not, more below) is start developing a sense of which of the two is your current obstacle to the task at hand, when you have one. 

For a while, I expect the main obstacle will be the "code" part. Which, as I told you, the great Fred Brooks called one of the "accidental" (e.g. "non essential") tasks of a programmer. But are you a programmer if you "get" all the concepts but can't write code? Or are you a programmer is you know every nuance of your particular programming language but can't for the life of you understand what it is you are supposed to be building with that language? 

So, sometimes you will get in the "zone" so to speak and be *cranking out* code. (really! It'll happen!). And then things will start grinding to a slow crawl. Things get brittle - every time you add some code, something else falls apart. Resist the temptation to solve those kinds of problems by "throwing more code at it". (side note, I think this is one of the dangers of AI, to be honest. You go to it in desperation and it turns you into a "throwing more code at it" super-soldier. Be careful.) What you need is more "context", more "concept". Step away for a little bit, talk through the whole thing. From my experience, cats are a great audience for this sort of thing. What I find is about 9 times out of 10 the problem isn't that I don't know something about the code I'm writing, the problem was there is some concept that I'm missing. It could be a *technical concept*, like, you ask your mentor and their like "oh yeah, you should be using **name of some obscure thing** here, I should have told you about that!", or it could be a concept that is somehow latent in the code you are writing. (latent: not discovered yet).

> I did my best to give you the "experience" of that with the thing I did with `TransactionAmount` in our bank account thing. But you can't really fake that sort of thing in class. It just doesn't work. You need your own "a-ha! Eureka!" moments. Canned examples fall short. 

We talked a bit about Larry Wall's "three virtues", but for me there is the addition of "being a sort of annoyed, petty, grumpy person when working on code is the perfect mindset!". I don't mean being nasty and critiquing other people constantly, but allow yourself to get a little *annoyed* when you have to write the same kind of thing over and over. Get even more annoyed when you discover a bug in your code, and then find that that same bug is all over the place. So, back to the Account class, when we discovered that we had a bug that allowed folks to deposit or withdraw using negative numbers, or even zero, It would have been pretty ok, like a gold star, if you said "Oh, I'll fix that!" and went and added some code to both the deposit and withdraw methods and elegantly kept that bug from surfacing again. There. In that part of the code. But the "galaxy brain" programmer says "Wow! I think that what I just realized is that yeah, an Account is an important thing, and deserves representation in our code, maybe the stuff you do stuff with an account is pretty important, too! You know, MONEY?". I just did a quick internet search - did you know that the United States Mint has never created a currency that advertised having a negative value? There has never been a USD -$5.00 bill. And how were we representing money in our code? The "decimal" data type, which the instructor did a fairly bad job even explaining. I mean, I guess it can't be an integer, or a string, or whatever, so cool. But we found that was "not quite it". 

The more things in a code base that technically "work" but are also "not quite it", the more bugs you'll have. And of equal importance to us, the shorter the life span of that code. Nobody will want to work on it. It'll be hard to learn, hard to maintain, and folks will live in fear of it. It will be officially "legacy code".

In week 2, we are going to explore this more, and I'm going to *push* you all to recognize this.

So, we were building that service the first couple of days, and then all of a sudden I stopped. We stopped. 

I detected (projected?) that the code was overwhelming your conceptual understanding. Remember that? When I said "ok, what do we need from the user to be able to provide the functionality we just listed out?" and I got CRICKETS. Your brains had shut down a bit. Too deep in the code. You lost the concept. 

As a programmer you have to both know what it is your are trying to accomplish, why you are trying to accomplish it, and then be able to implement it. That's the job. If you lose site of that, it's easy to get lost in the code. It *still* happens to me too often to admit. Within the previous three months of when I'm am writing this I can name at least one time I spent an entire day diligently, almost aggressively, writing some of the most amazing but *wrong* software of my life. The really embarrassing thing is that I have to admit that at some point during that day I sort of *knew* I was building the wrong thing. Maybe blame toxic masculinity or something, but I wasn't going to let *that* stop me from getting it to work!

> **Listen to the Friction** - if things get hard and challenging in coding, it *might* be because you are just "dumb" - ignorant, you don't know how to do something. Do a bit of research, figure it out. But consider it might be because you are just doing it wrong. That what you are trying to do isn't what *should* be done to solve the problem at hand. Like you are trying to dig a hole with a garden rake. 

## Part 2 of the Week: "Testing"

So, do you see how the four rules of simple design, and even the "form" of test-driven development are there to help us from getting into that horrible state of spinning our wheels? Ending up crying in the shower because we are a fraud! "I've seen so many holes dug! Everyone on my team digs the best holes, and I'm getting nowhere!".

It's so easy to get to that point. It's such a trap. The Greek Hero Ulysses tied himself to the mast of his ship so as not to be influenced by the sirens. I don't buy chips precisely because I know that one night I will eat the entire bag. We make contracts with ourselves.

### Contract 1: I need to know what I'm writing before I write it. How do I do that?

You do it. You don't worry about if it is great code, if it is the best implementation of solving a problem, you start with a solution. Write crappy code. **Understand how to solve the problem as a human first**. 

**"But what if the problem is too big for me to do that?"** Are you even *listening* to yourself? Every single project you will be a part of at your company is too big for you to understand - for anyone to understand - before actually writing the code. 

So our technique, our answer to that question is "break it down to some thing I can understand, that I can figure out, and start there".

But that can be a trap, too - we *often* don't know how hard something is until we try to do it! So, here's the strapping yourself to the mast part: Give yourself like let's say 10 minutes to solve a problem. If you can't do it within that time frame, you are solving too big of a problem. Delete your code, and break it down further.

Another trick along those lines is sometimes you discover during doing something pretty straight forward and obvious that there is a part of that that *isn't* so straight forward and obvious. This happens a *lot*. "Man, I was just *killing* it on those Bank Account story cards! And then that bonus calculation thing hit me. I ground to a halt.". 

That kind of thing is the code whispering to you "THIS DOES NOT BELONG HERE". This new thing you are struggling with is not *cohesive* with the thing you are currently working on. Later on you get get your head into the "calculating bonuses" mindset, and it won't be so challenging, but right now you are all ABOUT balance management. Stay there. Then worry about that other thing. 

### Summary: Testing

A big part of your job is going to be writing tests. *Some* of what we've seen will be helpful with that (we'll do some more "real" testing in Week 2). But this is more about using the tests to tie us to the mast, so to speak. "Help me remember what I am even trying to do before I descend into the world of the sirens!" 

- Write a Test that Meaningfully Fails (because when it passes, you know you are "done")

Because those sirens will be seductive. They will whisper "You know, you should add this other thing while you are here, you just *know* they are going to need it, right? So do it now". They will whisper things like "Oooh - you know what might be cool, actually? What if we did it this whole other way that you are thinking right now, you know, like that professional entertainer on Youtube said I should be doing it!". 

Just run your failing test again. Let that glaring red failing test be your beacon in the dark. Fix that. Then get "creative". You'll know so much more, even if it is "`if(numbers=="1") return 1;`" than you did before you started. Oh! I see I need a way to convert *any* string that contains an integer into it's integer version! Even if you don't know *how* to do that, now you have a search term, a prompt, or whatever. 

TLDR: You are great programmers. You are so good you got jobs at this amazing company. Nobody is going to to be judging you on your fancy programming chops. It would be like getting a job as an ice skating instructor and constantly trying to impress the other instructors with your fancy tricks. Your job is figuring out stuff. And once you have that stuff figured out, you understand it, then write enough code that we can move this project forward, because we are all just figuring out the best way to provide the solution we need with software, and don't want to get ahead of ourselves. 

**Your Job Is Not "Writing Code". If you could provide what the company needs with no code, that's a win! - Your job is to provide value, limit liability, etc. and you have the special skills of translating that to code.**

In other words, if you can't answer the question "Ok, we looked at the requirements, what do we need to collect from the user to be able to fulfill those requirements?" and not have *something* to say, no amount of leetcode mastery is going to save you. 

## Week Two

Week two we are going to do our best to work on that. A good place to practice that sort of thinking is in user interface - so we'll do some UI with Angular. 

You'll learn *some* Angular, but what I want you to practice is:

- Identifying latent concepts in our code.
- Breaking things down into small pieces that are easy to understand.
- Keeping the "big picture" in mind.

In other words, we are going to *apply* what we've done the first week.

And learn some cool tech stuff, too. 

