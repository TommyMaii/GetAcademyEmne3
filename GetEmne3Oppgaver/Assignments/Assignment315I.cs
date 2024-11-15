namespace Emne3GetAcademyOppgaver.Assignments;

public class Assignment315I
{
     static readonly Random Random = new Random();
    
    static char GetRandomLetter(char min, char max)
    {
        return (char)Random.Next(min, max);
    }
    
    static void Run(string[] args)
    {
        if (!IsValid(args[0], args[1]))
        {
            ShowHelpText();
            return;
        }
        string pattern = CreatePattern(args[0], args[1]);
        string password = "";
        int count = 0;
        while (pattern.Length > 0)
        {
            count++;
            int randomIndex = Random.Next(0, pattern.Length);
            char c = pattern[randomIndex];
            pattern = RemoveCharacter(pattern,randomIndex);
            password += CreatePassword(c, args[0].Length);
        }
        Console.WriteLine(password);
    }

    static string CreatePassword(char character, int inputPasswordLength)
    {
        string password = "";
        if(password.Length == inputPasswordLength ) {return password;}
        switch (character)
        {
            case 'l':
                password += WriteRandomLowerCaseLetter(password);
                break;
            case 'L':
                password += WriteRandomUpperCaseLetter(password);
                break;
            case 's':
                password += WriteRandomSpecialCharacter(password);
                break;            
            case 'd':
                password += WriteRandomDigit(password);
                break;
        }
        return password;
    }
    static string WriteRandomLowerCaseLetter(string password)
    {
        string newPassword = password.Insert(password.Length, GetRandomLetter('a','z').ToString());
        return newPassword;
    }    
    
    static string WriteRandomUpperCaseLetter(string password)
    {
        string newPassword = password.Insert(password.Length,  GetRandomLetter('A','Z').ToString());
        return newPassword;
    }    
    
    static string WriteRandomSpecialCharacter(string password)
    {
        const string specialCharacters = "!#¤%&/()=?`^*_-:";
        var randomNumber = Random.Next(0, specialCharacters.Length);
        var newPassword = password.Insert(password.Length, specialCharacters[randomNumber].ToString());
        return newPassword;
    }    
    
    static string WriteRandomDigit(string password)
    {
        string newPassword = password.Insert(password.Length, Random.Next(0,9).ToString());
        return newPassword;
    }

    static void ShowHelpText()
    {
        string text =
            "PasswordGenerator  \nOptions:\n- l = liten bokstav\n- L = stor bokstav\n- d = siffer\n- s = spesialtegn (!\"#\u00a4%&/(){}[]\nEksempel: PasswordGenerator 14 lLssdd\n    " +
            "betyr\n        Min. 1 liten bokstav\n        Min. 1 1 stor bokstav\n        Min. 2 spesialtegn\n        Min. 2 sifre\n        Lengde på passordet skal være 14";
        Console.WriteLine(text);
    }

    static string CreatePattern(string passwordLength, string inputText)
    {
        string pattern = inputText;
        int passLength = Convert.ToInt32(passwordLength);
        for (int i = inputText.Length; i < passLength; i++)
        {
            if (pattern.Length < passLength)
            {
                pattern = pattern.Insert(i,"l");
            }
        }
        return pattern;
    }

    static string RemoveCharacter(string inputText, int index)
    {
        string pattern = inputText.Remove(index,1);
        return pattern;
    }

    static bool IsValidLength(string inputPasswordLength, string inputText)
    {
        bool isValid = !(Convert.ToInt32(inputPasswordLength) < inputText.Length);
        return isValid;
    }
    static bool IsValid(string inputPasswordLength, string inputText)
    {
        return IsValidLenghtInput(inputPasswordLength) && IsValidOptionInput(inputText) && IsValidLength(inputPasswordLength, inputText);
    }

    static bool IsValidLenghtInput(string text)
    {
        bool isValid = false;
        foreach (var c in text)
        {
            if (char.IsDigit(c))
            {
                isValid = true;
            }
            else
            {
                isValid = false;
            }
        }
        return isValid;

    }    
    
    static bool IsValidOptionInput(string text)
    {
        bool isValid = false;
        foreach (var c in text)
        {
            if (c == 'l' || c == 'L' || c == 'd' || c == 's')
            {
                isValid = true;
            }
            else
            {
                isValid = false;
            }
        }
        return isValid;
    }
}