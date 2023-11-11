using MeasurementConverter.Length;
using MeasurementConverter.Length.Enums;

Console.WriteLine(LengthConverter.MetricToImperial(1, MetricLengthUnit.KILOMETER, ImperialLengthUnit.MILE));
Console.WriteLine(LengthConverter.ImperialToMetric(1, ImperialLengthUnit.MILE, MetricLengthUnit.METER));
