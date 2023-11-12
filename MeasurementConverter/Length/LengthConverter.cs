using MeasurementConverter.Length.Enums;

namespace MeasurementConverter.Length
{
    public class LengthConverter
    {
        // meter
        public static decimal MetricToMetric(decimal value, MetricLengthUnit fromUnit, MetricLengthUnit toUnit)
        {
            return value * LengthUnitValues.Metric[fromUnit] / LengthUnitValues.Metric[toUnit];
        }

        public static decimal ImperialToImperial(decimal value, ImperialLengthUnit fromUnit, ImperialLengthUnit toUnit)
        {
            return value * LengthUnitValues.Imperial[fromUnit] / LengthUnitValues.Imperial[toUnit];
        }

        public static decimal MetricToImperial(decimal value, MetricLengthUnit fromUnit, ImperialLengthUnit toUnit)
        {
            return ImperialToImperial(
                MetricToMetric(value, fromUnit, MetricLengthUnit.FOOT),
                ImperialLengthUnit.FOOT,
                toUnit
            );
        }

        public static decimal ImperialToMetric(decimal value, ImperialLengthUnit fromUnit, MetricLengthUnit toUnit)
        {
            return MetricToMetric(
                ImperialToImperial(value, fromUnit, ImperialLengthUnit.METER),
                MetricLengthUnit.METER,
                toUnit
            );
        }
    }
}