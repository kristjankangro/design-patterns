namespace KristjanDev;
/**
 * 1. muudatus main 1
 * 2. muudatus dev > 1
 * 3. muudatus dev > 2
 * 4. muudatus main
 */


//master muudatus
/**
 * more changes 111121, 3. muudatus
 * neljas muutus
 *
 * esimene mutuus dev2's
 *
 * viies
 */

//master 1
//master 2

public static class TranslationObjectService
{
    public static TranslationDto GetObject(ITranslationDtoGetter objectClass)
    {
        return objectClass.Get();
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