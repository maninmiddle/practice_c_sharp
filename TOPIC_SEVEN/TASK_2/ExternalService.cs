using System;

public class ExternalService
{
    public void PerformOperationThatMightFail()
    {
        throw new System.IO.FileNotFoundException("Файл не найден в стороннем сервисе.");
    }
}