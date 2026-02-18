# Use the Rest of the Day To:

- Try TDD - Kata 2 - You can use my code as a reference.
- But what I really want you doing is thinking about this test double thing.
- [Instructions Here](https://osherove.com/tdd-kata-2)
- Take my code, look at it. Read it. Debug it. 
- BUILD AS MUCH OF THIS MENTAL MODEL AS YOU CAN.
- At least get to the point where you can verbalize something close to a question.

- Why do we use test doubles?
- What is a test double?
- Extra Credit: what is meant by a dummy, stub, mock, or fake.
- Why is this so important?
- This is not the question: That you can do this on your own 100% 


This is about:

- testing. How do we "simulate and verify" the behavior of our code.
    - sometimes we have to "simulate and verify" things that don't even exist yet.
    - The need for a bonus calculator didn't appear at the beginning in our "requirements gathering phase" or whatever, it was "the business wants this BEHAVIOR, and our job is to make it so in code".
- Testing is 
    - Does the thing work right. "external code quality" - "The Tests Pass" 
    - Verifying the business worthiness of something
    - "does the thing right" - subjective - we are trying to write code that has some qualities to it. Not all code is equal.
    -  expresses intent, fewest number of elements,  duplication - "moist" or "rug" is best.
    -  reusable - not as common as you think. We aren't (usually) library or framework developers.
        - but we reuse "concepts" not "code" - for example, there is a HUGE difference between copying the following code into a new location:

```csharp
public void Deposit(decimal amount)
{
    if(amount <= 0) {
        throw new InvalidTransactionAmountException();
    }
    _balance += amount;
}

```

And our identifying a "concept" that is expressed by that `if` statement, which we labeled `TransactionAmount` - we can reuse THAT.

> Note: Realizing I did an overly-smart developer thing with the naming on TransactionAmount - maybe. I mean, what do most people call the thing
> we put into or take out of our accounts? "Yes, I'd like $250 in TransactionAmount, please?" - "Ubiquitous Language" - Domain Driven Design - just call it money, you dork. (see `TimeProvider` from Microsoft.)



- LOOSE COUPLING.
    - Coupling is the "strength of relationships between code modules"
    - The ability to change one thing without breaking another.
    - Changing implementation without changing interface.
    - You have to DESIGN software this way. It isn't natural. You have to do it intentionally.

- Write your code as if you are super skeptical that you or anybody else knows what the hell they are actually doing.
    - Because we don't often - things change over time. Bonuses get calculated differently later than they do now.
        - We need to assume our stuff is going to change, and we want to minimize the "blast radius".


- "Hypothesis Driven Development"
    - "Cool story bro, what are a couple things we can do soon to see if this is something we want to invest in?"