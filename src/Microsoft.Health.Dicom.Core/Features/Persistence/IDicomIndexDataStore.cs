﻿// -------------------------------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Dicom;

namespace Microsoft.Health.Dicom.Core.Features.Persistence
{
    public interface IDicomIndexDataStore
    {
        Task IndexInstanceAsync(DicomDataset instance, CancellationToken cancellationToken = default);

        Task<IEnumerable<DicomInstanceIdentifier>> DeleteStudyIndexAsync(string studyInstanceUID, CancellationToken cancellationToken = default);

        Task<IEnumerable<DicomInstanceIdentifier>> DeleteSeriesIndexAsync(string studyInstanceUID, string seriesInstanceUID, CancellationToken cancellationToken = default);

        Task DeleteInstanceIndexAsync(string studyInstanceUID, string seriesInstanceUID, string sopInstanceUID, CancellationToken cancellationToken = default);
    }
}
