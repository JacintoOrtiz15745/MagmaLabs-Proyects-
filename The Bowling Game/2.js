alert('The bowling game')
alert("The rules: \n1.-You have 10 opportunies \n2.-In every opportunities you have two throws \n3.-If you derive 10 pins in two throws it's a Spare \n4.-If you derive 10 pins on your first try it's a Strike \n5.-The bonus of Spare is the next first pins knocked down \n6.-The bonus of Strike is the next two pins knocked down ")
alert('REMEMBER \nThe Spares and Strikes they add up in the next oppotunity')
var score = 0;
var score2 = 0;
spare = new Boolean(false); /*SPARE CONTROL*/
strike = new Boolean(false); /*STRIKE CONTROL*/

  for(var i = 1;i < 11; i++)
  {
    var si = confirm('¡THROW THE BOWLS!')

    if(si == true)
    {
      for(var j = 1; j < 3; i++)
      {
        var aleat = Math.floor(Math.random()*11); /* */
        var aleat2 = Math.floor(Math.random()*(11 - aleat));
        var total = aleat + aleat2;
        score = score + aleat + aleat2;strike

        if(total < 10)  /* WWW */
        {
          if(spare == true)
          {
            score = score + aleat;
            spare = false;

          }

          else if(strike == true)
          {
            score = score + aleat + aleat2;
            strike = false;

          }

          alert('Opportunity #' + i +' \nThrow 1:  ' + aleat + '    Throw 2:  ' + aleat2 + '\nScore: ' + score)
        }

        else if(total < 10 && i == 10)
        {
          var aleat3 = Math.floor(Math.random()*(11 - aleat));
          score2 = score + score2 + aleat2;
          alert('Opportunity #' + i +' \nThrow 1:  ' + aleat + '    Throw 2:  ' + aleat2 + 'Throw 3:  ' + aleat3 +'\nScore: ' + score2)
        }

        else if(aleat == 0 && aleat2 == 10)  /* XXX */
        {
          spare = true;

          if(strike == true)
          {
            score = score + aleat + aleat2;
            strike = false;

          }

          alert('!Its a Spare¡ \nOpportunity #' + i +' \nThrow 1:  ' + aleat + '    Throw 2:  ' + aleat2 + '\nScore: ' + score)
        }

        else if(total < 10 && i == 10)
        {
          var aleat3 = Math.floor(Math.random()*(11 - aleat));
          score2 = score + score2 + aleat2;
          alert('!Its a Spare¡ \nOpportunity #' + i +' \nThrow 1:  ' + aleat + '    Throw 2:  ' + aleat2 + 'Throw 3:  ' + aleat3 +'\nScore: ' + score2)
        }

        else if(aleat == 10 && aleat2 == 0) /* YYY */
        {
          strike = true;

          if(spare == true)
          {
            score = score + aleat;
            spare = false;
          }

          else
          {
            score = score + aleat + aleat2;
          }
          alert('!Its a Strike¡ \nOpportunity #' + i +' \nThrow 1:  ' + aleat + '    Throw 2:  ' + aleat2 + '\nScore: ' + score)
        }

        else if(aleat == 10 && aleat2 == 0 && i == 10)
        {
          var aleat3 = Math.floor(Math.random()*(11 - aleat));
          score2 = score + score2 + aleat2;
          alert('Opportunity #' + i +' \nThrow 1:  ' + aleat + '    Throw 2:  ' + aleat2 + 'Throw 3:  ' + aleat3 +'\nScore: ' + score2)
        }

        break; /*LEAVE THE CYCLE*/
      }
    }

    if(i == 10) /*SCORE*/
    {
      alert('The Bowling Game \nScore total: ' + score)
    }
  }
