﻿using PS.Mothership.Core.Common.Rellaid.Dto;
using PS.Mothership.Core.Common.Template.Dial;
using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace PS.Mothership.Core.Common.Contracts
{
    [ServiceContract(Name = "DiallerService")]
    public interface IDiallerService
    {
        [OperationContract]
        ValidUserInfoDto ValidateUser(Guid mothershipSessionGuid);

        [OperationContract]
        Guid LogDiallerSessionSubscribe(Guid userGuid, Guid mothershipSessionGuid);

        [OperationContract]
        void LogDiallerSessionUnsubscribe(Guid userGuid, Guid mothershipSessionGuid, Guid diallerSessionGuid,
            bool wasForcedLogout, DialLogoutReasonEnum logoutReason);

        [OperationContract]
        IEnumerable<InboundQueueDetailsDto> GetInboundQueueDetails();

        [OperationContract]
        IEnumerable<MissingCallRecordingsDto> GetMissingCallRecordings(DateTime dateStart, DateTime dateEnd);

        [OperationContract]
        void UpdateRecorderCallIdForCallGuid(Guid callGuid, long recorderCallId, Guid mothershipSessionGuid);

        [OperationContract]
        Dictionary<long, long> TryToFindDiallerDepartmentsByUserGuid(Guid userGuid);

        [OperationContract]
        void InsertCallRecordingEvent(CallRecordingEventDto callRecordingEvent);

        [OperationContract]
        Guid LogDiallerModeChange(Guid userGuid, Guid mothershipSessionGuid, DialModeEnum diallerMode);

        [OperationContract]
        void LogNewDiallerCall(NewDiallerCallDto diallerCall);

        [OperationContract]
        void LogFinalisedCall(FinalisedDiallerCallDto diallerCall);

        [OperationContract]
        bool IsCallResolved(Guid prospectingCampaignCallGuid);

        [OperationContract]
        Guid AddOrUpdateSpeedDialNumber(Guid userGuid, SpeedDialNumberDto speedDialNumber);

        [OperationContract]
        void DeleteSpeedDialNumber(Guid userGuid, Guid speedDialNumberGuid);

        [OperationContract]
        IEnumerable<SipAccountDto> GetSipAccountList(Guid userSipAccountGuid);
    }
}
