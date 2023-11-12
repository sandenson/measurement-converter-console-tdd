namespace MeasurementConverter.Length.Enums
{
    public class LengthUnitValues
    {
        public static readonly IReadOnlyDictionary<MetricLengthUnit, decimal> Metric = new Dictionary<MetricLengthUnit, decimal>()
        {
            {MetricLengthUnit.RONNAMETER, 1000000000000000000000000000M},
            {MetricLengthUnit.YOTTAMETER, 1000000000000000000000000M},
            {MetricLengthUnit.ZETTAMETER, 1000000000000000000000M},
            {MetricLengthUnit.EXAMETER, 1000000000000000000M},
            {MetricLengthUnit.PETAMETER, 1000000000000000M},
            {MetricLengthUnit.TERAMETER, 1000000000000M},
            {MetricLengthUnit.GIGAMETER, 1000000000M},
            {MetricLengthUnit.MEGAMETER, 1000000M},
            {MetricLengthUnit.KILOMETER, 1000M},
            {MetricLengthUnit.HECTOMETER, 100M},
            {MetricLengthUnit.DECAMETER, 10M},
            {MetricLengthUnit.METER, 1M},
            {MetricLengthUnit.DECIMETER, 0.1M},
            {MetricLengthUnit.CENTIMETER, 0.01M},
            {MetricLengthUnit.MILIMETER, 0.001M},
            {MetricLengthUnit.MICROMETER, 0.000001M},
            {MetricLengthUnit.NANOMETER, 0.000000001M},
            {MetricLengthUnit.PICOMETER, 0.000000000001M},
            {MetricLengthUnit.FEMTOMETER, 0.000000000000001M},
            {MetricLengthUnit.ATTOMETER, 0.000000000000000001M},
            {MetricLengthUnit.ZEPTOMETER, 0.000000000000000000001M},
            {MetricLengthUnit.YOCTOMETER, 0.000000000000000000000001M},
            {MetricLengthUnit.RONTOMETER, 0.000000000000000000000000001M},
            {MetricLengthUnit.FOOT, 0.3048M},
        };

        public static readonly IReadOnlyDictionary<ImperialLengthUnit, decimal> Imperial = new Dictionary<ImperialLengthUnit, decimal>()
        {
            {ImperialLengthUnit.TWIP, 1M / 17280M},
            {ImperialLengthUnit.THOW, 1M / 12000M},
            {ImperialLengthUnit.BARLEYCORN, 1M / 36M},
            {ImperialLengthUnit.INCH, 1M / 12M},
            {ImperialLengthUnit.HAND, 1M / 3M},
            {ImperialLengthUnit.FOOT, 1M},
            {ImperialLengthUnit.YARD, 3M},
            {ImperialLengthUnit.CHAIN, 66M},
            {ImperialLengthUnit.FURLONG, 660M},
            {ImperialLengthUnit.MILE, 5280M},
            {ImperialLengthUnit.LEAGUE, 15840M},
            {ImperialLengthUnit.FATHOM, 6M},
            {ImperialLengthUnit.CABLE, 607.6M},
            {ImperialLengthUnit.NAUTICAL_MILE, 6076.115485564081M},
            {ImperialLengthUnit.LINK, 66M / 100M},
            {ImperialLengthUnit.ROD, 66M / 4M},
            {ImperialLengthUnit.METER, 3.28083989501M},
        };
    }
}