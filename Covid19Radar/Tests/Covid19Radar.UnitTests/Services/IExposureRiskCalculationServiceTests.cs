﻿// This Source Code Form is subject to the terms of the Mozilla Public
// License, v. 2.0. If a copy of the MPL was not distributed with this
// file, You can obtain one at https://mozilla.org/MPL/2.0/.

using System.Collections.Generic;
using Chino;
using Covid19Radar.Services;
using Xunit;

namespace Covid19Radar.UnitTests.Services
{
    public class IExposureRiskCalculationServiceTests
    {

        public IExposureRiskCalculationServiceTests()
        {
        }

        private IExposureRiskCalculationService CreateService()
        {
            return new ExposureRiskCalculationService();
        }

        [Fact]
        public void LowRiskExposureTest()
        {

            var dailySummary = new DailySummary()
                {
                    DateMillisSinceEpoch = 0,
                    DaySummary = new ExposureSummaryData()
                    {
                        ScoreSum = 1999.0
                    },
                    ConfirmedClinicalDiagnosisSummary = new ExposureSummaryData(),
                    ConfirmedTestSummary = new ExposureSummaryData(),
                    RecursiveSummary = new ExposureSummaryData(),
                    SelfReportedSummary = new ExposureSummaryData()
            };

            var exposureWindows = new List<ExposureWindow>()
            {
                new ExposureWindow()
                {
                    CalibrationConfidence = CalibrationConfidence.High,
                    DateMillisSinceEpoch = 0,
                    Infectiousness = Infectiousness.High,
                    ReportType = ReportType.Unknown,
                    ScanInstances = new List<ScanInstance>()
                }
            };

            IExposureRiskCalculationService service = CreateService();

            RiskLevel result = service.CalcRiskLevel(dailySummary, exposureWindows);

            Assert.Equal(RiskLevel.Low, result);
        }

        [Fact]
        public void HighRiskExposureTest()
        {

            var dailySummary = new DailySummary()
            {
                DateMillisSinceEpoch = 0,
                DaySummary = new ExposureSummaryData()
                {
                    ScoreSum = 2000.0
                },
                ConfirmedClinicalDiagnosisSummary = new ExposureSummaryData(),
                ConfirmedTestSummary = new ExposureSummaryData(),
                RecursiveSummary = new ExposureSummaryData(),
                SelfReportedSummary = new ExposureSummaryData()
            };

            var exposureWindows = new List<ExposureWindow>()
            {
                new ExposureWindow()
                {
                    CalibrationConfidence = CalibrationConfidence.High,
                    DateMillisSinceEpoch = 0,
                    Infectiousness = Infectiousness.High,
                    ReportType = ReportType.Unknown,
                    ScanInstances = new List<ScanInstance>()
                }
            };

            IExposureRiskCalculationService service = CreateService();

            RiskLevel result = service.CalcRiskLevel(dailySummary, exposureWindows);

            Assert.Equal(RiskLevel.High, result);
        }
    }
}
