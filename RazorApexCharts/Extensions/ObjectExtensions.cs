namespace RazorApexCharts.Extensions;

public static class ObjectExtensions
{
    public static bool IsNumeric(this object obj)
    {
        switch(Type.GetTypeCode(obj.GetType()))
        {
            case TypeCode.Byte:
            case TypeCode.SByte:
            case TypeCode.UInt16:
            case TypeCode.UInt32:
            case TypeCode.UInt64:
            case TypeCode.Int16:
            case TypeCode.Int32:
            case TypeCode.Int64:
            case TypeCode.Decimal:
            case TypeCode.Double:
            case TypeCode.Single:
                return true;
            default:
                return false;
        }
    }
    
    public static bool IsDateTime(this object obj)
    {
        switch(Type.GetTypeCode(obj.GetType()))
        {
            case TypeCode.DateTime:
                return true;
            default:
                return false;
        }
    }
}