using System;

namespace exception
{
    class Program
    {
        class TestException : Exception
        {

        }

        static void TestFunc()
        {
            throw new TestException();
        }

        static void Main(string[] args)
        {
            try
            {
                // 1. 0으로 나눌 때
                // 2. 잘못된 메모리를 참조 (null)
                // 3. 오버플로우
                
                // throw new TestException();
                TestFunc();
            }
            catch (DivideByZeroException e) 
            {

            }
            catch (Exception e)
            {

            }
            finally
            {
                // DB, 파일 정리 등등
            }
        }
    }
}
