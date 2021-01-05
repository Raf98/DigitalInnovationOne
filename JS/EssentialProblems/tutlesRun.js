let greatestSpeed = 0;

let L = parseInt(gets());

let count = 1;

while(count <= 3) 
{
  greatestSpeed = 0;
  
  let turtleSpeedStr = gets();
  let turtlesSpeed = turtleSpeedStr.split(' ');
    
  for(let i = 0; i < L; ++i)
  {
    if(parseInt(turtlesSpeed[i]) > greatestSpeed)
    {
      greatestSpeed =  parseInt(turtlesSpeed[i]);
    }  
  }
  
  if(greatestSpeed < 10)
    console.log(1)
  else if(greatestSpeed >= 10 && greatestSpeed < 20)
    console.log(2)
  else if(greatestSpeed >= 20)
    console.log(3)
    
  L = parseInt(gets());
  ++count;
}
