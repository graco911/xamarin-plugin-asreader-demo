using System;
using Foundation;
using ObjCRuntime;

// @interface RcpBarcodeApi : NSObject
[BaseType (typeof(NSObject))]
interface RcpBarcodeApi
{
	// -(NSString *)getSDKVersion;
	[Export ("getSDKVersion")]
	string SDKVersion { get; }

	// -(BOOL)open;
	[Export ("open")]
	bool Open { get; }

	// -(BOOL)isOpened;
	[Export ("isOpened")]
	bool IsOpened { get; }

	// -(void)close;
	[Export ("close")]
	void Close ();

	// -(BOOL)startReadBarcodes:(uint8_t)mtnu mtime:(uint8_t)mtime repeatCycle:(uint16_t)repeatCycle;
	[Export ("startReadBarcodes:mtime:repeatCycle:")]
	bool StartReadBarcodes (byte mtnu, byte mtime, ushort repeatCycle);

	// -(BOOL)stopReadBarcodes;
	[Export ("stopReadBarcodes")]
	bool StopReadBarcodes { get; }

	// -(BOOL)setReaderPower:(BOOL)on;
	[Export ("setReaderPower:")]
	bool SetReaderPower (bool on);

	// -(void)setReaderPowerOnWithBeep:(uint8_t)beepOn setVibration:(uint8_t)vibrationOn setIllumination:(uint8_t)illuminationOn;
	[Export ("setReaderPowerOnWithBeep:setVibration:setIllumination:")]
	void SetReaderPowerOnWithBeep (byte beepOn, byte vibrationOn, byte illuminationOn);

	// -(BOOL)setBeep:(uint8_t)beepOn setVibration:(uint8_t)vibrationOn setIllumination:(uint8_t)illuminationOn;
	[Export ("setBeep:setVibration:setIllumination:")]
	bool SetBeep (byte beepOn, byte vibrationOn, byte illuminationOn);

	// @property (assign, nonatomic) BOOL isConnected;
	[Export ("isConnected")]
	bool IsConnected { get; set; }

	[Wrap ("WeakDelegate")]
	[NullAllowed]
	RcpBarcodeDelegate Delegate { get; set; }

	// @property (nonatomic, weak) id<RcpBarcodeDelegate> _Nullable delegate;
	[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
	NSObject WeakDelegate { get; set; }

	// @property (nonatomic, strong) NSString * model;
	[Export ("model", ArgumentSemantic.Strong)]
	string Model { get; set; }
}

// @protocol RcpBarcodeDelegate <NSObject>
[Protocol, Model]
[BaseType (typeof(NSObject))]
interface RcpBarcodeDelegate
{
	// @optional -(void)readerConnected:(uint8_t)status;
	[Export ("readerConnected:")]
	void ReaderConnected (byte status);

	// @optional -(void)pluggedBarcode:(BOOL)plug;
	[Export ("pluggedBarcode:")]
	void PluggedBarcode (bool plug);

	// @optional -(void)barcodeReceived:(NSData *)barcode;
	[Export ("barcodeReceived:")]
	void BarcodeReceived (NSData barcode);

	// @optional -(void)barcodeStringReceived:(NSString *)barcode;
	[Export ("barcodeStringReceived:")]
	void BarcodeStringReceived (string barcode);

	// @optional -(void)batteryChargeReceived:(int)battery;
	[Export ("batteryChargeReceived:")]
	void BatteryChargeReceived (int battery);

	// @optional -(void)startedReadBarcodes:(uint8_t)statusCode;
	[Export ("startedReadBarcodes:")]
	void StartedReadBarcodes (byte statusCode);

	// @optional -(void)stoppedReadBarcodes:(uint8_t)statusCode;
	[Export ("stoppedReadBarcodes:")]
	void StoppedReadBarcodes (byte statusCode);

	// @optional -(void)errReceived:(uint8_t)errCode;
	[Export ("errReceived:")]
	void ErrReceived (byte errCode);

	// @optional -(void)errDetailReceived:(NSData *)errCode;
	[Export ("errDetailReceived:")]
	void ErrDetailReceived (NSData errCode);
}

// @interface RcpRfidApi : NSObject
[BaseType (typeof(NSObject))]
interface RcpRfidApi
{
	// -(NSString *)getSDKVersion;
	[Export ("getSDKVersion")]
	string SDKVersion { get; }

	// -(BOOL)open;
	[Export ("open")]
	bool Open { get; }

	// -(BOOL)isOpened;
	[Export ("isOpened")]
	bool IsOpened { get; }

	// -(void)close;
	[Export ("close")]
	void Close ();

	// -(void)plugStatusChanged:(NSInteger)status;
	[Export ("plugStatusChanged:")]
	void PlugStatusChanged (nint status);

	// -(int)receive:(NSData *)data;
	[Export ("receive:")]
	int Receive (NSData data);

	// -(BOOL)setReaderPower:(BOOL)on;
	[Export ("setReaderPower:")]
	bool SetReaderPower (bool on);

	// -(void)setReaderPowerOnWithBeep:(uint8_t)beepOn setVibration:(uint8_t)vibrationOn setIllumination:(uint8_t)illuminationOn;
	[Export ("setReaderPowerOnWithBeep:setVibration:setIllumination:")]
	void SetReaderPowerOnWithBeep (byte beepOn, byte vibrationOn, byte illuminationOn);

	// -(BOOL)setBeep:(uint8_t)beepOn setVibration:(uint8_t)vibrationOn setIllumination:(uint8_t)illuminationOn;
	[Export ("setBeep:setVibration:setIllumination:")]
	bool SetBeep (byte beepOn, byte vibrationOn, byte illuminationOn);

	// -(BOOL)startReadTags:(uint8_t)mtnu mtime:(uint8_t)mtime repeatCycle:(uint16_t)repeatCycle;
	[Export ("startReadTags:mtime:repeatCycle:")]
	bool StartReadTags (byte mtnu, byte mtime, ushort repeatCycle);

	// -(BOOL)startReadTagsWithRssi:(uint8_t)mtnu mtime:(uint8_t)mtime repeatCycle:(uint16_t)repeatCycle;
	[Export ("startReadTagsWithRssi:mtime:repeatCycle:")]
	bool StartReadTagsWithRssi (byte mtnu, byte mtime, ushort repeatCycle);

	// -(BOOL)startReadTagsWithTid:(uint8_t)mtnu mtime:(uint8_t)mtime repeatCycle:(uint16_t)repeatCycle;
	[Export ("startReadTagsWithTid:mtime:repeatCycle:")]
	bool StartReadTagsWithTid (byte mtnu, byte mtime, ushort repeatCycle);

	// -(BOOL)stopReadTags;
	[Export ("stopReadTags")]
	bool StopReadTags { get; }

	// -(BOOL)getReaderInfo;
	[Export ("getReaderInfo")]
	bool ReaderInfo { get; }

	// -(BOOL)getReaderInfo:(uint8_t)infoType;
	[Export ("getReaderInfo:")]
	bool GetReaderInfo (byte infoType);

	// -(BOOL)getRegion;
	[Export ("getRegion")]
	bool Region { get; }

	// -(BOOL)setRegion:(uint8_t)region;
	[Export ("setRegion:")]
	bool SetRegion (byte region);

	// -(BOOL)getSelectParam;
	[Export ("getSelectParam")]
	bool SelectParam { get; }

	// -(BOOL)setSelectParam:(uint8_t)target action:(uint8_t)action memoryBank:(uint8_t)memoryBank pointer:(uint32_t)pointer length:(uint8_t)length truncate:(uint8_t)truncate mask:(NSData *)mask;
	[Export ("setSelectParam:action:memoryBank:pointer:length:truncate:mask:")]
	bool SetSelectParam (byte target, byte action, byte memoryBank, uint pointer, byte length, byte truncate, NSData mask);

	// -(BOOL)getChannel;
	[Export ("getChannel")]
	bool Channel { get; }

	// -(BOOL)setChannel:(uint8_t)channel channelOffset:(uint8_t)channelOffset;
	[Export ("setChannel:channelOffset:")]
	bool SetChannel (byte channel, byte channelOffset);

	// -(BOOL)getFhLbtParam;
	[Export ("getFhLbtParam")]
	bool FhLbtParam { get; }

	// -(BOOL)setFhLbtParam:(uint16_t)readTime idleTime:(uint16_t)idleTime carrierSenseTime:(uint16_t)carrierSenseTime rfLevel:(uint16_t)rfLevel frequencyHopping:(uint8_t)frequencyHopping listenBeforeTalk:(uint8_t)listenBeforeTalk continuousWave:(uint8_t)continuousWave;
	[Export ("setFhLbtParam:idleTime:carrierSenseTime:rfLevel:frequencyHopping:listenBeforeTalk:continuousWave:")]
	bool SetFhLbtParam (ushort readTime, ushort idleTime, ushort carrierSenseTime, ushort rfLevel, byte frequencyHopping, byte listenBeforeTalk, byte continuousWave);

	// -(BOOL)getOutputPowerLevel;
	[Export ("getOutputPowerLevel")]
	bool OutputPowerLevel { get; }

	// -(BOOL)setOutputPowerLevel:(uint16_t)power;
	[Export ("setOutputPowerLevel:")]
	bool SetOutputPowerLevel (ushort power);

	// -(BOOL)readFromTagMemory:(uint32_t)accessPassword epc:(NSData *)epc memoryBank:(uint8_t)memoryBank startAddress:(uint16_t)startAddress dataLength:(uint16_t)dataLength;
	[Export ("readFromTagMemory:epc:memoryBank:startAddress:dataLength:")]
	bool ReadFromTagMemory (uint accessPassword, NSData epc, byte memoryBank, ushort startAddress, ushort dataLength);

	// -(BOOL)getFreqHoppingTable;
	[Export ("getFreqHoppingTable")]
	bool FreqHoppingTable { get; }

	// -(BOOL)setFreqHoppingTable:(uint8_t)tableSize channels:(NSData *)channels;
	[Export ("setFreqHoppingTable:channels:")]
	bool SetFreqHoppingTable (byte tableSize, NSData channels);

	// -(BOOL)getSession;
	[Export ("getSession")]
	bool Session { get; }

	// -(BOOL)setSession:(uint8_t)session;
	[Export ("setSession:")]
	bool SetSession (byte session);

	// -(BOOL)getAnticollision;
	[Export ("getAnticollision")]
	bool Anticollision { get; }

	// -(BOOL)setAnticollision:(uint8_t)mode;
	[Export ("setAnticollision:")]
	bool SetAnticollision (byte mode);

	// -(BOOL)setAnticollision:(uint8_t)mode qStart:(uint8_t)qStart qMax:(uint8_t)qMax qMin:(uint8_t)qMin;
	[Export ("setAnticollision:qStart:qMax:qMin:")]
	bool SetAnticollision (byte mode, byte qStart, byte qMax, byte qMin);

	// -(BOOL)writeToTagMemory:(uint32_t)accessPassword epc:(NSData *)epc memoryBank:(uint8_t)memoryBank startAddress:(uint16_t)startAddress dataToWrite:(NSData *)dataToWrite;
	[Export ("writeToTagMemory:epc:memoryBank:startAddress:dataToWrite:")]
	bool WriteToTagMemory (uint accessPassword, NSData epc, byte memoryBank, ushort startAddress, NSData dataToWrite);

	// -(BOOL)killTag:(uint32_t)killPassword epc:(NSData *)epc;
	[Export ("killTag:epc:")]
	bool KillTag (uint killPassword, NSData epc);

	// -(BOOL)lockTagMemory:(uint32_t)accessPassword epc:(NSData *)epc lockData:(uint32_t)lockData;
	[Export ("lockTagMemory:epc:lockData:")]
	bool LockTagMemory (uint accessPassword, NSData epc, uint lockData);

	// -(BOOL)getRssi;
	[Export ("getRssi")]
	bool Rssi { get; }

	// -(BOOL)setStopConditionMtnu:(uint8_t)mtnu setMtime:(uint8_t)mtime setRepeatCycle:(uint16_t)repeatCycle;
	[Export ("setStopConditionMtnu:setMtime:setRepeatCycle:")]
	bool SetStopConditionMtnu (byte mtnu, byte mtime, ushort repeatCycle);

	// -(BOOL)getStopCondition;
	[Export ("getStopCondition")]
	bool StopCondition { get; }

	// -(BOOL)genericTrasport:(uint8_t)TS ap:(uint32_t)accessPassword RM:(uint8_t)RM epc:(NSData *)epc SZ:(uint8_t)SZ GC:(NSData *)GC;
	[Export ("genericTrasport:ap:RM:epc:SZ:GC:")]
	bool GenericTrasport (byte TS, uint accessPassword, byte RM, NSData epc, byte SZ, NSData GC);

	// -(void)setGpadc;
	[Export ("setGpadc")]
	void SetGpadc ();

	// -(BOOL)getRssiOffset;
	[Export ("getRssiOffset")]
	bool RssiOffset { get; }

	// -(BOOL)setRssiOffset;
	[Export ("setRssiOffset")]
	bool SetRssiOffset { get; }

	// -(BOOL)setOptimumFrequencyHoppingTable;
	[Export ("setOptimumFrequencyHoppingTable")]
	bool SetOptimumFrequencyHoppingTable { get; }

	// -(BOOL)GetFrequencyHoppingMode;
	[Export ("GetFrequencyHoppingMode")]
	bool FrequencyHoppingMode { get; }

	// -(BOOL)SetFrequencyHoppingMode:(uint8_t)mode;
	[Export ("SetFrequencyHoppingMode:")]
	bool SetFrequencyHoppingMode (byte mode);

	// -(BOOL)updateRegistry;
	[Export ("updateRegistry")]
	bool UpdateRegistry { get; }

	// @property (assign, nonatomic) BOOL isConnected;
	[Export ("isConnected")]
	bool IsConnected { get; set; }

	[Wrap ("WeakDelegate")]
	[NullAllowed]
	RcpRfidDelegate Delegate { get; set; }

	// @property (nonatomic, weak) id<RcpRfidDelegate> _Nullable delegate;
	[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
	NSObject WeakDelegate { get; set; }
}

// @protocol RcpRfidDelegate <NSObject>
[Protocol, Model]
[BaseType (typeof(NSObject))]
interface RcpRfidDelegate
{
	// @optional -(void)pluggedRfid:(BOOL)plug;
	[Export ("pluggedRfid:")]
	void PluggedRfid (bool plug);

	// @optional -(void)pcEpcReceived:(NSData *)pcEpc;
	[Export ("pcEpcReceived:")]
	void PcEpcReceived (NSData pcEpc);

	// @optional -(void)epcReceived:(NSData *)epc;
	[Export ("epcReceived:")]
	void EpcReceived (NSData epc);

	// @optional -(void)epcReceived:(NSData *)epc rssi:(int8_t)rssi;
	[Export ("epcReceived:rssi:")]
	void EpcReceived (NSData epc, sbyte rssi);

	// @optional -(void)epcReceived:(NSData *)epc tid:(NSData *)tid;
	[Export ("epcReceived:tid:")]
	void EpcReceived (NSData epc, NSData tid);

	// @optional -(void)pcEpcRssiReceived:(NSData *)pcEpc rssi:(int8_t)rssi;
	[Export ("pcEpcRssiReceived:rssi:")]
	void PcEpcRssiReceived (NSData pcEpc, sbyte rssi);

	// @optional -(void)readerConnected:(uint8_t)status;
	[Export ("readerConnected:")]
	void ReaderConnected (byte status);

	// @optional -(void)readerConnected;
	[Export ("readerConnected")]
	void ReaderConnected ();

	// @optional -(void)errReceived:(uint8_t)errCode;
	[Export ("errReceived:")]
	void ErrReceived (byte errCode);

	// @optional -(void)errDetailReceived:(NSData *)errCode;
	[Export ("errDetailReceived:")]
	void ErrDetailReceived (NSData errCode);

	// @optional -(void)readerInfoReceived:(NSData *)data;
	[Export ("readerInfoReceived:")]
	void ReaderInfoReceived (NSData data);

	// @optional -(void)frequencyHoppingModeReceived:(uint8_t)statusCode;
	[Export ("frequencyHoppingModeReceived:")]
	void FrequencyHoppingModeReceived (byte statusCode);

	// @optional -(void)regionReceived:(uint8_t)region;
	[Export ("regionReceived:")]
	void RegionReceived (byte region);

	// @optional -(void)selectParamReceived:(NSData *)selParam;
	[Export ("selectParamReceived:")]
	void SelectParamReceived (NSData selParam);

	// @optional -(void)channelReceived:(uint8_t)channel channelOffset:(uint8_t)channelOffset;
	[Export ("channelReceived:channelOffset:")]
	void ChannelReceived (byte channel, byte channelOffset);

	// @optional -(void)fhLbtReceived:(NSData *)fhLb;
	[Export ("fhLbtReceived:")]
	void FhLbtReceived (NSData fhLb);

	// @optional -(void)txPowerLevelReceived:(NSData *)power;
	[Export ("txPowerLevelReceived:")]
	void TxPowerLevelReceived (NSData power);

	// @optional -(void)tagMemoryReceived:(NSData *)data;
	[Export ("tagMemoryReceived:")]
	void TagMemoryReceived (NSData data);

	// @optional -(void)hoppingTableReceived:(NSData *)table;
	[Export ("hoppingTableReceived:")]
	void HoppingTableReceived (NSData table);

	// @optional -(void)anticolParamReceived:(uint8_t)param;
	[Export ("anticolParamReceived:")]
	void AnticolParamReceived (byte param);

	// @optional -(void)anticolParamReceived:(uint8_t)mode start:(uint8_t)start max:(uint8_t)max min:(uint8_t)min;
	[Export ("anticolParamReceived:start:max:min:")]
	void AnticolParamReceived (byte mode, byte start, byte max, byte min);

	// @optional -(void)rssiReceived:(uint16_t)rssi;
	[Export ("rssiReceived:")]
	void RssiReceived (ushort rssi);

	// @optional -(void)batteryChargeReceived:(int)battery;
	[Export ("batteryChargeReceived:")]
	void BatteryChargeReceived (int battery);

	// @optional -(void)startedReadTags:(uint8_t)statusCode;
	[Export ("startedReadTags:")]
	void StartedReadTags (byte statusCode);

	// @optional -(void)startedReadTagsWithRssi:(uint8_t)statusCode;
	[Export ("startedReadTagsWithRssi:")]
	void StartedReadTagsWithRssi (byte statusCode);

	// @optional -(void)didSetOutputPowerLevel:(uint8_t)status;
	[Export ("didSetOutputPowerLevel:")]
	void DidSetOutputPowerLevel (byte status);

	// @optional -(void)writedReceived:(uint8_t)statusCode;
	[Export ("writedReceived:")]
	void WritedReceived (byte statusCode);

	// @optional -(void)stoppedReadTags:(uint8_t)statusCode;
	[Export ("stoppedReadTags:")]
	void StoppedReadTags (byte statusCode);

	// @optional -(void)lockedReceived:(uint8_t)statusCode;
	[Export ("lockedReceived:")]
	void LockedReceived (byte statusCode);

	// @optional -(void)killedReceived:(uint8_t)statusCode;
	[Export ("killedReceived:")]
	void KilledReceived (byte statusCode);

	// @optional -(void)didSetRegionReceived:(uint8_t)statusCode;
	[Export ("didSetRegionReceived:")]
	void DidSetRegionReceived (byte statusCode);

	// @optional -(void)didSetSelParamReceived:(uint8_t)statusCode;
	[Export ("didSetSelParamReceived:")]
	void DidSetSelParamReceived (byte statusCode);

	// @optional -(void)didSetChParamReceived:(uint8_t)statusCode;
	[Export ("didSetChParamReceived:")]
	void DidSetChParamReceived (byte statusCode);

	// @optional -(void)didSetFhLbtReceived:(uint8_t)statusCode;
	[Export ("didSetFhLbtReceived:")]
	void DidSetFhLbtReceived (byte statusCode);

	// @optional -(void)didSetTxPwrReceived:(uint8_t)statusCode;
	[Export ("didSetTxPwrReceived:")]
	void DidSetTxPwrReceived (byte statusCode);

	// @optional -(void)didSetHoppintTbleReceived:(uint8_t)statusCode;
	[Export ("didSetHoppintTbleReceived:")]
	void DidSetHoppintTbleReceived (byte statusCode);

	// @optional -(void)didSetAntiColModeReceived:(uint8_t)statusCode;
	[Export ("didSetAntiColModeReceived:")]
	void DidSetAntiColModeReceived (byte statusCode);

	// @optional -(void)sessionReceived:(uint8_t)session;
	[Export ("sessionReceived:")]
	void SessionReceived (byte session);

	// @optional -(void)didSetStopConditionMtnu:(uint8_t)statusCode;
	[Export ("didSetStopConditionMtnu:")]
	void DidSetStopConditionMtnu (byte statusCode);

	// @optional -(void)stopConditionReceived:(NSData *)data;
	[Export ("stopConditionReceived:")]
	void StopConditionReceived (NSData data);

	// @optional -(void)didSetOptiFreqHPTable:(uint8_t)statusCode;
	[Export ("didSetOptiFreqHPTable:")]
	void DidSetOptiFreqHPTable (byte statusCode);

	// @optional -(void)didSetFreqHPTable:(uint8_t)statusCode;
	[Export ("didSetFreqHPTable:")]
	void DidSetFreqHPTable (byte statusCode);

	// @optional -(void)didSetFreqHPMode:(uint8_t)statusCode;
	[Export ("didSetFreqHPMode:")]
	void DidSetFreqHPMode (byte statusCode);

	// @optional -(void)didSetSession:(uint8_t)statusCode;
	[Export ("didSetSession:")]
	void DidSetSession (byte statusCode);

	// @optional -(void)updatedRegistry:(uint8_t)statusCode;
	[Export ("updatedRegistry:")]
	void UpdatedRegistry (byte statusCode);
}
