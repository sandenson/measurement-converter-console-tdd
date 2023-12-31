using MeasurementConverter.Length;
using MeasurementConverter.Length.Enums;

namespace MeasurementConverter.Test;

public class UnitTest1
{
    private static decimal ToFixedDecimal(decimal value, int decimalPlaces)
    {
        return decimal.Parse(value.ToString("N" + decimalPlaces));
    }

    [Theory]
    [InlineData(1, MetricLengthUnit.KILOMETER, MetricLengthUnit.METER, 1000)]
    [InlineData(1637, MetricLengthUnit.MILIMETER, MetricLengthUnit.METER, 1.637)]
    [InlineData(15, MetricLengthUnit.NANOMETER, MetricLengthUnit.FEMTOMETER, 15000000)]
    [InlineData(0.48, MetricLengthUnit.MEGAMETER, MetricLengthUnit.HECTOMETER, 4800)]
    [InlineData(37.99, MetricLengthUnit.CENTIMETER, MetricLengthUnit.CENTIMETER, 37.99)]
    public void ShouldConvertMeasuresFromOneMetricUnitToAnotherAndReturnTheExpectedResult(
        decimal value, MetricLengthUnit fromUnit, MetricLengthUnit toUnit, decimal expected
    )
    {
        decimal result = LengthConverter.MetricToMetric(value, fromUnit, toUnit);

        Assert.Equal(ToFixedDecimal(expected, 5), ToFixedDecimal(result, 5));
    }

    [Theory]
    [InlineData(6, ImperialLengthUnit.FOOT, ImperialLengthUnit.INCH, 72)]
    [InlineData(7, ImperialLengthUnit.NAUTICAL_MILE, ImperialLengthUnit.MILE, 8.055456136164501)]
    [InlineData(338, ImperialLengthUnit.YARD, ImperialLengthUnit.FURLONG, 1.53636)]
    [InlineData(0.75, ImperialLengthUnit.CHAIN, ImperialLengthUnit.ROD, 3)]
    [InlineData(39, ImperialLengthUnit.LEAGUE, ImperialLengthUnit.FATHOM, 102960)]
    public void ShouldConvertMeasuresFromOneImperialUnitToAnotherAndReturnTheExpectedResult(
        decimal value, ImperialLengthUnit fromUnit, ImperialLengthUnit toUnit, decimal expected
    )
    {
        decimal result = LengthConverter.ImperialToImperial(value, fromUnit, toUnit);

        Assert.Equal(ToFixedDecimal(expected, 5), ToFixedDecimal(result, 5));
    }

    [Theory]
    [InlineData(59, MetricLengthUnit.MICROMETER, ImperialLengthUnit.TWIP, 3.344881889763793)]
    [InlineData(622, MetricLengthUnit.MILIMETER, ImperialLengthUnit.BARLEYCORN, 73.46456692884)]
    [InlineData(1243, MetricLengthUnit.METER, ImperialLengthUnit.CHAIN, 61.78915)]
    [InlineData(66, MetricLengthUnit.KILOMETER, ImperialLengthUnit.MILE, 41.0105)]
    [InlineData(0.000000985, MetricLengthUnit.TERAMETER, ImperialLengthUnit.NAUTICAL_MILE, 531.857451403888)]
    public void ShouldConvertMeasuresFromAMetricUnitToAnImperialUnitAndReturnTheExpectedResult(
        decimal value, MetricLengthUnit fromUnit, ImperialLengthUnit toUnit, decimal expected
    )
    {
        decimal result = LengthConverter.MetricToImperial(value, fromUnit, toUnit);

        Assert.Equal(ToFixedDecimal(expected, 5), ToFixedDecimal(result, 5));
    }

    [Theory]
    [InlineData(59, ImperialLengthUnit.TWIP, MetricLengthUnit.MILIMETER, 1.0406944444444401)]
    [InlineData(73, ImperialLengthUnit.BARLEYCORN, MetricLengthUnit.DECIMETER, 6.180666666691389)] // here
    [InlineData(61, ImperialLengthUnit.CHAIN, MetricLengthUnit.DECAMETER, 122.71248093555997)]
    [InlineData(41, ImperialLengthUnit.MILE, MetricLengthUnit.KILOMETER, 65.983104)]
    [InlineData(985, ImperialLengthUnit.NAUTICAL_MILE, MetricLengthUnit.MEGAMETER, 1.8242193359841616)]
    public void ShouldConvertMeasuresFromAnImperialUnitToAMetricUnitAndReturnTheExpectedResult(
        decimal value, ImperialLengthUnit fromUnit, MetricLengthUnit toUnit, decimal expected
    )
    {
        decimal result = LengthConverter.ImperialToMetric(value, fromUnit, toUnit);

        Assert.Equal(ToFixedDecimal(expected, 5), ToFixedDecimal(result, 5));
    }

    [Fact]
    public void ShouldConvertMeasuresTooHighAndThrowOverflowException()
    {
        Assert.Throws<OverflowException>(
            () => LengthConverter.MetricToMetric(
                decimal.MaxValue, MetricLengthUnit.RONNAMETER, MetricLengthUnit.RONTOMETER
            )
        );

        Assert.Throws<OverflowException>(
            () => LengthConverter.ImperialToImperial(
                decimal.MaxValue, ImperialLengthUnit.NAUTICAL_MILE, ImperialLengthUnit.TWIP
            )
        );

        Assert.Throws<OverflowException>(
            () => LengthConverter.MetricToImperial(
                decimal.MaxValue, MetricLengthUnit.RONNAMETER, ImperialLengthUnit.TWIP
            )
        );

        Assert.Throws<OverflowException>(
            () => LengthConverter.ImperialToMetric(
                decimal.MaxValue, ImperialLengthUnit.NAUTICAL_MILE, MetricLengthUnit.RONTOMETER
            )
        );
    }
}