namespace KristjanDev;

public static class TranslationObjectService
{
    public static TranslationDto GetObject(ITranslationDtoGetter objectClass)
    {
        return objectClass.Get();
    }

    public static string ToString()
    {
        return "";
    }
}


public class TranslationDto
{
    public string ET;
    public string EN;
    public string RU;
    public string Key;
}

public interface ITranslationDtoGetter
{
    TranslationDto Get();
}

public class Type1 : ITranslationDtoGetter
{
    public string type1Name;
    public string type1Key;

    public TranslationDto Get()
    {
        return new TranslationDto
        {
            ET = type1Name,
            EN = type1Name,
            RU = type1Name,
            Key = type1Key
        };
    }
}

public class Type2 : ITranslationDtoGetter
{
    public string type2Name;
    public string type2Key;

    public TranslationDto Get()
    {
        return new TranslationDto
        {
            ET = type2Name,
            EN = type2Name,
            RU = type2Name,
            Key = type2Key
        };
    }
}

public class Type3 : ITranslationDtoGetter
{
    public string type3Name;
    public string type3Key;

    public TranslationDto Get()
    {
        return new TranslationDto
        {
            ET = type3Name,
            EN = type3Name,
            RU = type3Name,
            Key = type3Key
        };
    }
}