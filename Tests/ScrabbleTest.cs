using Xunit;
using Scrabble.Objects;
using System;
using System.Collections.Generic;

namespace Scrabble
{
    public class ScrabbleTest
    {
        [Fact]
        public void ScrabbleScore_OneLetterScore_true()
        {
          Assert.Equal(ScrabbleApp.ScrabbleScore("a"), 1);

            //arrange
            //act
            //assert
        }
        [Fact]
        public void ScrabbleScore_WholeWordScore_true()
        {
          Assert.Equal(ScrabbleApp.ScrabbleScore("baseball"), 12);


        }

        [Fact]
        public void ScrabbleScore_CapitalWordScore_true()
        {
          Assert.Equal(ScrabbleApp.ScrabbleScore("BaSeBaLl"), 12);


        }
    }
}
