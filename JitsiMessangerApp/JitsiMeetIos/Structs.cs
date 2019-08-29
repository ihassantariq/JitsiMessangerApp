﻿using System;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;

namespace WebRTC
{
    [Native]
    public enum RTCVideoRotation : ulong
    {
        RTCVideoRotation_0 = 0,
        RTCVideoRotation_90 = 90,
        RTCVideoRotation_180 = 180,
        RTCVideoRotation_270 = 270
    }

    [Native]
    public enum RTCFrameType : ulong
    {
        EmptyFrame = 0,
        AudioFrameSpeech = 1,
        AudioFrameCN = 2,
        VideoFrameKey = 3,
        VideoFrameDelta = 4
    }

    [Native]
    public enum RTCVideoContentType : ulong
    {
        Unspecified,
        Screenshare
    }

    [Native]
    public enum RTCVideoCodecMode : ulong
    {
        RealtimeVideo,
        Screensharing
    }

    [Native]
    public enum RTCSourceState : ulong
    {
        Initializing,
        Live,
        Ended,
        Muted
    }

    [Native]
    public enum RTCMediaStreamTrackState : ulong
    {
        Live,
        Ended
    }

    [Native]
    public enum RTCIceTransportPolicy : ulong
    {
        None,
        Relay,
        NoHost,
        All
    }

    [Native]
    public enum RTCBundlePolicy : ulong
    {
        Balanced,
        MaxCompat,
        MaxBundle
    }

    [Native]
    public enum RTCRtcpMuxPolicy : ulong
    {
        Negotiate,
        Require
    }

    [Native]
    public enum RTCTcpCandidatePolicy : ulong
    {
        Enabled,
        Disabled
    }

    [Native]
    public enum RTCCandidateNetworkPolicy : ulong
    {
        All,
        LowCost
    }

    [Native]
    public enum RTCContinualGatheringPolicy : ulong
    {
        Once,
        Continually
    }

    [Native]
    public enum RTCEncryptionKeyType : ulong
    {
        Rsa,
        Ecdsa
    }

    [Native]
    public enum RTCSdpSemantics : ulong
    {
        PlanB,
        UnifiedPlan
    }

    [Native]
    public enum RTCDataChannelState : ulong
    {
        Connecting,
        Open,
        Closing,
        Closed
    }

    [Native]
    public enum RTCDispatcherQueueType : ulong
    {
        Main,
        CaptureSession,
        AudioSession
    }

    static class CFunctions
    {
        // extern NSString * RTCFieldTrialMedianSlopeFilterValue (size_t windowSize, double thresholdGain) __attribute__((visibility("default")));
        [DllImport("__Internal")]
        static extern NSString RTCFieldTrialMedianSlopeFilterValue(uint windowSize, double thresholdGain);

        // extern NSString * RTCFieldTrialTrendlineFilterValue (size_t windowSize, double smoothingCoeff, double thresholdGain) __attribute__((visibility("default")));
        [DllImport("__Internal")]
        static extern NSString RTCFieldTrialTrendlineFilterValue(uint windowSize, double smoothingCoeff, double thresholdGain);

        // extern void RTCInitFieldTrialDictionary (NSDictionary<NSString *,NSString *> *fieldTrials) __attribute__((visibility("default")));
        [DllImport("__Internal")]
        static extern void RTCInitFieldTrialDictionary(NSDictionary<NSString, NSString> fieldTrials);

        // extern void RTCLogEx (RTCLoggingSeverity severity, NSString *log_string) __attribute__((visibility("default")));
        [DllImport("__Internal")]
        static extern void RTCLogEx(RTCLoggingSeverity severity, NSString log_string);

        // extern void RTCSetMinDebugLogLevel (RTCLoggingSeverity severity) __attribute__((visibility("default")));
        [DllImport("__Internal")]

        static extern void RTCSetMinDebugLogLevel(RTCLoggingSeverity severity);

        // extern NSString * RTCFileName (const char *filePath) __attribute__((visibility("default")));
        [DllImport("__Internal")]

        static extern unsafe NSString RTCFileName(sbyte* filePath);

        // extern void RTCEnableMetrics () __attribute__((visibility("default")));
        [DllImport("__Internal")]

        static extern void RTCEnableMetrics();

        // extern NSArray<RTCMetricsSampleInfo *> * RTCGetAndResetMetrics () __attribute__((visibility("default")));
        [DllImport("__Internal")]

        static extern RTCMetricsSampleInfo[] RTCGetAndResetMetrics();

        // extern BOOL RTCInitializeSSL () __attribute__((visibility("default")));
        [DllImport("__Internal")]

        static extern bool RTCInitializeSSL();

        // extern BOOL RTCCleanupSSL () __attribute__((visibility("default")));
        [DllImport("__Internal")]

        static extern bool RTCCleanupSSL();

        // extern void RTCSetupInternalTracer () __attribute__((visibility("default")));
        [DllImport("__Internal")]

        static extern void RTCSetupInternalTracer();

        // extern BOOL RTCStartInternalCapture (NSString *filePath) __attribute__((visibility("default")));
        [DllImport("__Internal")]

        static extern bool RTCStartInternalCapture(NSString filePath);

        // extern void RTCStopInternalCapture () __attribute__((visibility("default")));
        [DllImport("__Internal")]

        static extern void RTCStopInternalCapture();

        // extern void RTCShutdowuinternalTracer () __attribute__((visibility("default")));
        [DllImport("__Internal")]

        static extern void RTCShutdowuinternalTracer();
    }

    [Native]
    public enum RTCTlsCertPolicy : ulong
    {
        Secure,
        InsecureNoCheck
    }

    [Native]
    public enum RTCLoggingSeverity : ulong
    {
        Verbose,
        Info,
        Warning,
        Error
    }

    [Native]
    public enum RTCSignalingState : ulong
    {
        Stable,
        HaveLocalOffer,
        HaveLocalPrAnswer,
        HaveRemoteOffer,
        HaveRemotePrAnswer,
        Closed
    }

    [Native]
    public enum RTCIceConnectionState : ulong
    {
        New,
        Checking,
        Connected,
        Completed,
        Failed,
        Disconnected,
        Closed,
        Count
    }

    [Native]
    public enum RTCIceGatheringState : ulong
    {
        New,
        Gathering,
        Complete
    }

    [Native]
    public enum RTCStatsOutputLevel : ulong
    {
        Standard,
        Debug
    }

    [Native]
    public enum RTCRtpMediaType : ulong
    {
        Audio,
        Video,
        Data
    }

    [Native]
    public enum RTCRtpTransceiverDirection : ulong
    {
        SendRecv,
        SendOnly,
        RecvOnly,
        Inactive
    }

    [Native]
    public enum RTCSdpType : ulong
    {
        Offer,
        PrAnswer,
        Answer
    }

    [Native]
    public enum RTCH264PacketizationMode : ulong
    {
        Nouinterleaved = 0,
        SingleNalUnit
    }

    [Native]
    public enum RTCH264Profile : ulong
    {
        ConstrainedBaseline,
        Baseline,
        Main,
        ConstrainedHigh,
        High
    }

    [Native]
    public enum RTCH264Level : ulong
    {
        RTCH264Level1_b = 0,
        RTCH264Level1 = 10,
        RTCH264Level1_1 = 11,
        RTCH264Level1_2 = 12,
        RTCH264Level1_3 = 13,
        RTCH264Level2 = 20,
        RTCH264Level2_1 = 21,
        RTCH264Level2_2 = 22,
        RTCH264Level3 = 30,
        RTCH264Level3_1 = 31,
        RTCH264Level3_2 = 32,
        RTCH264Level4 = 40,
        RTCH264Level4_1 = 41,
        RTCH264Level4_2 = 42,
        RTCH264Level5 = 50,
        RTCH264Level5_1 = 51,
        RTCH264Level5_2 = 52
    }

    [Native]
    public enum RTCDeviceType : ulong
    {
        Unknown,
        IPhone1G,
        IPhone3G,
        IPhone3GS,
        IPhone4,
        IPhone4Verizon,
        IPhone4S,
        IPhone5GSM,
        IPhone5GSM_CDMA,
        IPhone5CGSM,
        IPhone5CGSM_CDMA,
        IPhone5SGSM,
        IPhone5SGSM_CDMA,
        IPhone6Plus,
        IPhone6,
        IPhone6S,
        IPhone6SPlus,
        IPhone7,
        IPhone7Plus,
        IPhoneSE,
        IPhone8,
        IPhone8Plus,
        IPhoneX,
        IPodTouch1G,
        IPodTouch2G,
        IPodTouch3G,
        IPodTouch4G,
        IPodTouch5G,
        IPodTouch6G,
        IPad,
        IPad2Wifi,
        IPad2GSM,
        IPad2CDMA,
        IPad2Wifi2,
        IPadMiniWifi,
        IPadMiniGSM,
        IPadMiniGSM_CDMA,
        IPad3Wifi,
        IPad3GSM_CDMA,
        IPad3GSM,
        IPad4Wifi,
        IPad4GSM,
        IPad4GSM_CDMA,
        IPad5,
        IPad6,
        IPadAirWifi,
        IPadAirCellular,
        IPadAirWifiCellular,
        IPadAir2,
        IPadMini2GWifi,
        IPadMini2GCellular,
        IPadMini2GWifiCellular,
        IPadMini3,
        IPadMini4,
        IPadPro9Inch,
        IPadPro12Inch,
        IPadPro12Inch2,
        IPadPro10Inch,
        Simulatori386,
        Simulatorx86_64
    }

    [Native]
    public enum RTCFileLoggerSeverity : ulong
    {
        Verbose,
        Info,
        Warning,
        Error
    }

    [Native]
    public enum RTCFileLoggerRotationType : ulong
    {
        Call,
        App
    }
}
