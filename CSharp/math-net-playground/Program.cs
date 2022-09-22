using MathNet.Numerics.Distributions;
using MathNet.Numerics.Statistics;

Console.WriteLine("Creating sample data");
var samples = new ChiSquared(5).Samples().Take(10000).ToArray();

// Calculate the mean and standard deviation
Console.WriteLine("Calculating mean and standard deviation");
var mean = samples.Mean();
var stdDev = samples.StandardDeviation();

// Calculate z score of last sample
Console.WriteLine("Calculating z score of last sample");
var zScore = (samples.Last() - mean) / stdDev;

// Print the results
Console.WriteLine("Mean: {0}", mean);
Console.WriteLine("Standard Deviation: {0}", stdDev);
Console.WriteLine("Z Score: {0}", zScore);

// Create different sample data
Console.WriteLine("Creating different sample data");
var samples2 = new ChiSquared(5).Samples().Take(10000).ToArray();

// Correlate the two samples
Console.WriteLine("Calculating correlation between samples");
var correlation = Correlation.Pearson(samples, samples2);

// Print the result
Console.WriteLine("Correlation: {0}", correlation);
