﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.

namespace Microsoft.Azure.EventGrid
{
    /// <summary>
    ///  Represents the names of the various event types for the system events published to
    ///  Azure Event Grid.
    /// </summary>
    public class EventTypes
    {
        // Keep this sorted by the name of the service publishing the events.

        // ContainerRegistry events
        public const string ContainerRegistryImagePushedEvent = "Microsoft.ContainerRegistry.ImagePushed";
        public const string ContainerRegistryImageDeletedEvent = "Microsoft.ContainerRegistry.ImageDeleted";

        // Device events
        public const string IoTHubDeviceCreatedEvent = "Microsoft.Devices.DeviceCreated";
        public const string IoTHubDeviceDeletedEvent = "Microsoft.Devices.DeviceDeleted";
        public const string IoTHubDeviceConnectedEvent = "Microsoft.Devices.DeviceConnected";
        public const string IoTHubDeviceDisconnectedEvent = "Microsoft.Devices.DeviceDisconnected";

        // EventGrid events
        public const string EventGridSubscriptionValidationEvent = "Microsoft.EventGrid.SubscriptionValidationEvent";
        public const string EventGridSubscriptionDeletedEvent = "Microsoft.EventGrid.SubscriptionDeletedEvent";

        // Event Hub Events
        public const string EventHubCaptureFileCreatedEvent = "Microsoft.EventHub.CaptureFileCreated";

        // Media Services events
        public const string MediaJobStateChangeEvent = "Microsoft.Media.JobStateChange";
        public const string MediaJobOutputStateChangeEvent = "Microsoft.Media.JobOutputStateChange";
        public const string MediaJobScheduledEvent = "Microsoft.Media.JobScheduled";
        public const string MediaJobProcessingEvent = "Microsoft.Media.JobProcessing";
        public const string MediaJobCancelingEvent = "Microsoft.Media.JobCanceling";
        public const string MediaJobFinishedEvent = "Microsoft.Media.JobFinished";
        public const string MediaJobCanceledEvent = "Microsoft.Media.JobCanceled";
        public const string MediaJobErroredEvent = "Microsoft.Media.JobErrored";
        public const string MediaJobOutputCanceledEvent = "Microsoft.Media.JobOutputCanceled";
        public const string MediaJobOutputCancelingEvent = "Microsoft.Media.JobOutputCanceling";
        public const string MediaJobOutputErroredEvent = "Microsoft.Media.JobOutputErrored";
        public const string MediaJobOutputFinishedEvent = "Microsoft.Media.JobOutputFinished";
        public const string MediaJobOutputProcessingEvent = "Microsoft.Media.JobOutputProcessing";
        public const string MediaJobOutputScheduledEvent = "Microsoft.Media.JobOutputScheduled";
        public const string MediaLiveEventEncoderConnectedEvent = "Microsoft.Media.LiveEventEncoderConnected";
        public const string MediaLiveEventConnectionRejectedEvent = "Microsoft.Media.LiveEventConnectionRejected";
        public const string MediaLiveEventEncoderDisconnectedEvent = "Microsoft.Media.LiveEventEncoderDisconnected";
        public const string MediaLiveEventIncomingStreamReceivedEvent = "Microsoft.Media.LiveEventIncomingStreamReceived";
        public const string MediaLiveEventIncomingStreamsOutOfSyncEvent = "Microsoft.Media.LiveEventIncomingStreamsOutOfSync";
        public const string MediaLiveEventIncomingVideoStreamsOutOfSyncEvent = "Microsoft.Media.LiveEventIncomingVideoStreamsOutOfSync";
        public const string MediaLiveEventIncomingChunkDroppedEvent = "Microsoft.Media.LiveEventIncomingChunkDropped";
        public const string MediaLiveEventIngestHeartbeatEvent = "Microsoft.Media.LiveEventIngestHeartbeat";
        public const string MediaLiveEventTrackDiscontinuityDetectedEvent = "Microsoft.Media.LiveEventTrackDiscontinuityDetected";

        // Resource Manager (Azure Subscription/Resource Group) events
        public const string ResourceWriteSuccessEvent = "Microsoft.Resources.ResourceWriteSuccess";
        public const string ResourceWriteFailureEvent = "Microsoft.Resources.ResourceWriteFailure";
        public const string ResourceWriteCancelEvent = "Microsoft.Resources.ResourceWriteCancel";
        public const string ResourceDeleteSuccessEvent = "Microsoft.Resources.ResourceDeleteSuccess";
        public const string ResourceDeleteFailureEvent = "Microsoft.Resources.ResourceDeleteFailure";
        public const string ResourceDeleteCancelEvent = "Microsoft.Resources.ResourceDeleteCancel";
        public const string ResourceActionSuccessEvent = "Microsoft.Resources.ResourceActionSuccess";
        public const string ResourceActionFailureEvent = "Microsoft.Resources.ResourceActionFailure";
        public const string ResourceActionCancelEvent = "Microsoft.Resources.ResourceActionCancel";

        // ServiceBus events
        public const string ServiceBusActiveMessagesAvailableWithNoListenersEvent = "Microsoft.ServiceBus.ActiveMessagesAvailableWithNoListeners";
        public const string ServiceBusDeadletterMessagesAvailableWithNoListenerEvent = "Microsoft.ServiceBus.DeadletterMessagesAvailableWithNoListener";

        // Storage events
        public const string StorageBlobCreatedEvent = "Microsoft.Storage.BlobCreated";
        public const string StorageBlobDeletedEvent = "Microsoft.Storage.BlobDeleted";
    }
}
