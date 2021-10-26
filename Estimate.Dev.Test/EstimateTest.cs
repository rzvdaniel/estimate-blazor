using System;
using Xunit;
using Estimate.Dev.Resources;

namespace Estimate.Dev.Test
{
    public class EstimateTest
    {
        [Fact]
        public void CalculateProbabilityDistribution()
        {
            var estimate = new Estimate(1m, 3m, 12m);
            var expectedProbability = 4.2m;
            var actualProbability = estimate.CalculateProbabilityDistribution();

            Assert.Equal(expectedProbability, actualProbability);
        }

        [Fact]
        public void CalculateStandardDeviation()
        {
            var estimate = new Estimate(1m, 3m, 12m);
            var expectedDeviation = 1.8m;
            var actualDeviation = estimate.CalculateStandardDeviation();

            Assert.Equal(expectedDeviation, actualDeviation);
        }

        [Fact]
        public void ValidateArgumentsRelationship()
        {
            var estimate = new Estimate(1m, 2m, 3m);
            var actualValidation = estimate.ValidateArguments();
            var expectedValidation = true;

            Assert.Equal(expectedValidation, actualValidation);
        }


        [Fact]
        public void ValidatePositiveArguments()
        {
            var estimate = new Estimate(1m, 3m, 12m);
            var actualValidation = estimate.ValidateArguments();
            var expectedValidation = true;

            Assert.Equal(expectedValidation, actualValidation);
        }

        [Fact]
        public void ValidateNegativeOptimistic()
        {
            var estimate = new Estimate(-1m, 1m, 2m);
            var exception = Assert.Throws<ArgumentException>(() => estimate.ValidateArguments());

            Assert.Equal(Errors.OptimisticNegative, exception.Message);
        }

        [Fact]
        public void ValidateNegativeNominal()
        {
            var estimate = new Estimate(1m, -2m, 3m);
            var exception = Assert.Throws<ArgumentException>(() => estimate.ValidateArguments());

            Assert.Equal(Errors.NominalNegative, exception.Message);
        }

        [Fact]
        public void ValidateNegativePessimistic()
        {
            var estimate = new Estimate(1m, 2m, -3m);
            var exception = Assert.Throws<ArgumentException>(() => estimate.ValidateArguments());

            Assert.Equal(Errors.PessimisticNegative, exception.Message);
        }

        [Fact]
        public void ValidateOptimisticBiggerThanNominal()
        {
            var estimate = new Estimate(2m, 1m, 3m);
            var exception = Assert.Throws<ArgumentException>(() => estimate.ValidateArguments());

            Assert.Equal(Errors.OptimisticBiggerThanNominal, exception.Message);
        }

        [Fact]
        public void ValidateNominalBiggerThanPessimistic()
        {
            var estimate = new Estimate(1m, 3m, 2m);
            var exception = Assert.Throws<ArgumentException>(() => estimate.ValidateArguments());

            Assert.Equal(Errors.NominalBiggerThanPessimistic, exception.Message);
        }
    }
}