# in-class-activities
## Devlogs
### W1
We see from where the camera is, and it does not move with the cat. This is due to the fact that it is no longer a child of the cat, so it will not actively move with it.
[Itch Link](https://thomasf2.itch.io/cat)

### W2
1. The r, g, and b variables are floats due to the fact that RGB data is stored in decimals, and in our case it is stored in the RGB 0-1.0
2. The _bounce variable is an int because we want to store the amount of bounces that the ball has as a whole number. Also, you can't have a decimal amount of bounces.
3. The error said that there was a missing semi-colon/;, which is useful as it tells us that we need a semicolon to end a line of code in C#. From experience in Java, I believe that this is because C#, like Java, is a language that ignores whitespace.

### W3
Table 12

#### Activity 1
1.Parameters:int or float and boolean  Return Type:string

int and float both work for a friendship level as it is numbers, and string is for text 

2.Parameters:float or int              Return Type:void

float or int both work for percentages, depending on formatting, there is no return so void

3.Parameters:                          Return Type:boolean

boolean as return for if beat is hit or not, no parameters

#### Activity 2
Classes are basically a blueprint for a Component, a building. The methods are what special utilities that the building can do and is used for, and member variables are the building's properties such as shape, height, etc;

#### Activity 3
The balls get extremely bright when they bounce too many times because earlier in step 1, we made it so that the balls multiply their speed by their speed multiplier. So, as the balls bounce more, the speed is multiplied higher
(assuming we have a above 1 multiplier). In step 8, our GetColorMultiplier method will eventually return a color multiplier of 1.5 when the balls reach and go over the _speedThreshold. Then, the code in step 9 multiplies the
ball's color by that multiplier, which increases the brightness as that is one of the values of color.


## Open-Source Assets
### W1
- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 