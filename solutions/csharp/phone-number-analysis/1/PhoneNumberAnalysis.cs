public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        string[] phoneNumberBlocks = phoneNumber.Split("-");

        return (phoneNumberBlocks[0] == "212", phoneNumberBlocks[1] == "555", phoneNumberBlocks[2]);
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo) => phoneNumberInfo.IsFake;

}
