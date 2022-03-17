namespace Converter.Models;

public class ConversionResponse
{
    public double Value { get; set; }
    public string ValueType { get; set; }

    public List<ConversionResponse> Convert(ConversionRequest request)
    {
        List<ConversionResponse> response = new List<ConversionResponse>();
        if (request.TypeToConvert == ConversionRequest.ValueType.Gallons)
        {
            var baseType = ((ConversionRequest.ValueType)ConversionRequest.ValueType.Gallons).ToString();
            var targetType = ((ConversionRequest.ValueType)ConversionRequest.ValueType.Liters).ToString();
            response.Add(new ConversionResponse { Value = request.Value, ValueType = baseType });
            response.Add(new ConversionResponse { Value = request.Value * 3.785, ValueType = targetType });
            return response;
        }
        else if (request.TypeToConvert == ConversionRequest.ValueType.Liters)
        {
            var baseType = ((ConversionRequest.ValueType)ConversionRequest.ValueType.Liters).ToString();
            var targetType = ((ConversionRequest.ValueType)ConversionRequest.ValueType.Gallons).ToString();
            response.Add(new ConversionResponse { Value = request.Value, ValueType = baseType });
            response.Add(new ConversionResponse { Value = request.Value * 0.26417, ValueType = targetType });
            return response;
        }
        else if (request.TypeToConvert == ConversionRequest.ValueType.Miles)
        {
            var baseType = ((ConversionRequest.ValueType)ConversionRequest.ValueType.Miles).ToString();
            var targetType = ((ConversionRequest.ValueType)ConversionRequest.ValueType.Kilometeres).ToString();
            response.Add(new ConversionResponse { Value = request.Value, ValueType = baseType });
            response.Add(new ConversionResponse { Value = request.Value * 1.609, ValueType = targetType });
            return response;
        }
        else if (request.TypeToConvert == ConversionRequest.ValueType.Kilometeres)
        {
            var baseType = ((ConversionRequest.ValueType)ConversionRequest.ValueType.Kilometeres).ToString();
            var targetType = ((ConversionRequest.ValueType)ConversionRequest.ValueType.Miles).ToString();
            response.Add(new ConversionResponse { Value = request.Value, ValueType = baseType });
            response.Add(new ConversionResponse { Value = request.Value * 0.62137, ValueType = targetType });
            return response;
        }
        else if (request.TypeToConvert == ConversionRequest.ValueType.Pounds)
        {
            var baseType = ((ConversionRequest.ValueType)ConversionRequest.ValueType.Pounds).ToString();
            var targetType = ((ConversionRequest.ValueType)ConversionRequest.ValueType.Kilograms).ToString();
            response.Add(new ConversionResponse { Value = request.Value, ValueType = baseType });
            response.Add(new ConversionResponse { Value = request.Value * 0.45359, ValueType = targetType });
            return response;
        }
        else if (request.TypeToConvert == ConversionRequest.ValueType.Kilograms)
        {
            var baseType = ((ConversionRequest.ValueType)ConversionRequest.ValueType.Kilograms).ToString();
            var targetType = ((ConversionRequest.ValueType)ConversionRequest.ValueType.Pounds).ToString();
            response.Add(new ConversionResponse { Value = request.Value, ValueType = baseType });
            response.Add(new ConversionResponse { Value = request.Value * 2.2046, ValueType = targetType });
            return response;
        }
        else if (request.TypeToConvert == ConversionRequest.ValueType.Yards)
        {
            var baseType = ((ConversionRequest.ValueType)ConversionRequest.ValueType.Yards).ToString();
            var targetType = ((ConversionRequest.ValueType)ConversionRequest.ValueType.Meters).ToString();
            response.Add(new ConversionResponse { Value = request.Value, ValueType = baseType });
            response.Add(new ConversionResponse { Value = request.Value * 0.9144, ValueType = targetType });
            return response;
        }
        else if (request.TypeToConvert == ConversionRequest.ValueType.Meters)
        {
            var baseType = ((ConversionRequest.ValueType)ConversionRequest.ValueType.Meters).ToString();
            var targetType = ((ConversionRequest.ValueType)ConversionRequest.ValueType.Yards).ToString();
            response.Add(new ConversionResponse { Value = request.Value, ValueType = baseType });
            response.Add(new ConversionResponse { Value = request.Value * 1.0936, ValueType = targetType });
            return response;
        }
        else if (request.TypeToConvert == ConversionRequest.ValueType.Feet)
        {
            var baseType = ((ConversionRequest.ValueType)ConversionRequest.ValueType.Feet).ToString();
            var targetType = ((ConversionRequest.ValueType)ConversionRequest.ValueType.Centimeters).ToString();
            response.Add(new ConversionResponse { Value = request.Value, ValueType = baseType });
            response.Add(new ConversionResponse { Value = request.Value * 30.48, ValueType = targetType });
            return response;
        }
        else if (request.TypeToConvert == ConversionRequest.ValueType.Centimeters)
        {
            var baseType = ((ConversionRequest.ValueType)ConversionRequest.ValueType.Centimeters).ToString();
            var targetType = ((ConversionRequest.ValueType)ConversionRequest.ValueType.Feet).ToString();
            response.Add(new ConversionResponse { Value = request.Value, ValueType = baseType });
            response.Add(new ConversionResponse { Value = request.Value * 0.3937, ValueType = targetType });
            return response;
        }
        return response;
    }

}