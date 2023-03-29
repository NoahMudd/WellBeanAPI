# WellBeanAPI
WellBeanAPI is a service that allows users to track certain health data points. They are prompted to answer a survey at the end of each day, and rate their sense of wellbeing. These data points are intended to give the user a sense of what habits make them feel their best.

## Features of this API: 
* Make your application an API
* Make your application a CRUD API
* Make your application asynchronous

### Current State
The current state of the API uses SwaggerUI to allow user input, which is then stored in memory. This means user input is not saved in between sessions. I have previously connected the API to a local database, so some artifacts of that are left in the code. A better user interface, more useful data storage, and graphing of some data is planned for the future.

### Test Json to Copy into SwaggerUI
{
  "userName": "Baked Bean",
  "minutesExercised": 5,
  "ozWater": 80,
  "dietRating": 3,
  "hoursSlept": 15,
  "didYouWork": false,
  "wellbeingRating": 10
}

{
  "userName": "String Bean",
  "minutesExercised": 100,
  "ozWater": 80,
  "dietRating": 8,
  "hoursSlept": 9,
  "didYouWork": true,
  "wellbeingRating": 7
}

{
  "userName": "Mr. Bean",
  "minutesExercised": 12,
  "ozWater": 70,
  "dietRating": 5,
  "hoursSlept": 4,
  "didYouWork": true,
  "wellbeingRating": 9
}

{
   "userName": "Green Bean",
   "minutesExercised": 0,
   "ozWater": 1,
   "dietRating": 1,
   "hoursSlept": 5,
   "didYouWork": true,
   "wellbeingRating": 2
}

{
    "userName": "Jelly Bean",
    "minutesExercised": 20,
    "ozWater": 32,
    "dietRating": 7,
    "hoursSlept": 7,
    "didYouWork": true,
    "wellbeingRating": 7
}

**Note: SwaggerUI only allows one entity to be created at a time**
