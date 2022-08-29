using FluentAssertions;

namespace LongestIncreasingSubsequence.Tests
{
    public class LongestIncreasingSubsequenceComponentTest
    {
        private readonly LongestIncreasingSubsequenceComponent _sut;
       


        public LongestIncreasingSubsequenceComponentTest()
        {
            _sut = new LongestIncreasingSubsequenceComponent();
        }

        [Fact]
        public void Check_For_Empty_Input_String_Of_Integers()
        {
            string inputString = "";

            Action act = () => _sut.GetEarliestLongestIncreasingSubsequence(inputString);

            act.Should().Throw<ArgumentNullException>().WithParameterName("message", "Please Enter Valid String of Integers seperated by single space");

        }


    }
}