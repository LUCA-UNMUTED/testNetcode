//using UnityEngine;
//using Normal.Realtime;
//using Normal.Realtime.Serialization;

//[RealtimeModel]
//public partial class BrushStrokeModel {
//    [RealtimeProperty(1, true)]
//    private RealtimeArray<RibbonPointModel> _ribbonPoints;

//    [RealtimeProperty(2, false)]
//    private Vector3 _brushTipPosition;

//    [RealtimeProperty(3, false)]
//    private Quaternion _brushTipRotation;

//    [RealtimeProperty(4, true)]
//    private bool _brushStrokeFinalized;
//}

///* ----- Begin Normal Autogenerated Code ----- */
//public partial class BrushStrokeModel : RealtimeModel {
//    public UnityEngine.Vector3 brushTipPosition {
//        get {
//            return _brushTipPositionProperty.value;
//        }
//        set {
//            if (_brushTipPositionProperty.value == value) return;
//            _brushTipPositionProperty.value = value;
//            InvalidateUnreliableLength();
//        }
//    }
    
//    public UnityEngine.Quaternion brushTipRotation {
//        get {
//            return _brushTipRotationProperty.value;
//        }
//        set {
//            if (_brushTipRotationProperty.value == value) return;
//            _brushTipRotationProperty.value = value;
//            InvalidateUnreliableLength();
//        }
//    }
    
//    public bool brushStrokeFinalized {
//        get {
//            return _brushStrokeFinalizedProperty.value;
//        }
//        set {
//            if (_brushStrokeFinalizedProperty.value == value) return;
//            _brushStrokeFinalizedProperty.value = value;
//            InvalidateReliableLength();
//        }
//    }
    
//    public Normal.Realtime.Serialization.RealtimeArray<RibbonPointModel> ribbonPoints {
//        get => _ribbonPoints;
//    }
    
//    public enum PropertyID : uint {
//        RibbonPoints = 1,
//        BrushTipPosition = 2,
//        BrushTipRotation = 3,
//        BrushStrokeFinalized = 4,
//    }
    
//    #region Properties
    
//    private ModelProperty<Normal.Realtime.Serialization.RealtimeArray<RibbonPointModel>> _ribbonPointsProperty;
    
//    private UnreliableProperty<UnityEngine.Vector3> _brushTipPositionProperty;
    
//    private UnreliableProperty<UnityEngine.Quaternion> _brushTipRotationProperty;
    
//    private ReliableProperty<bool> _brushStrokeFinalizedProperty;
    
//    #endregion
    
//    public BrushStrokeModel() : base(null) {
//        RealtimeModel[] childModels = new RealtimeModel[1];
        
//        _ribbonPoints = new Normal.Realtime.Serialization.RealtimeArray<RibbonPointModel>();
//        childModels[0] = _ribbonPoints;
        
//        SetChildren(childModels);
        
//        _ribbonPointsProperty = new ModelProperty<Normal.Realtime.Serialization.RealtimeArray<RibbonPointModel>>(1, _ribbonPoints);
//        _brushTipPositionProperty = new UnreliableProperty<UnityEngine.Vector3>(2, _brushTipPosition);
//        _brushTipRotationProperty = new UnreliableProperty<UnityEngine.Quaternion>(3, _brushTipRotation);
//        _brushStrokeFinalizedProperty = new ReliableProperty<bool>(4, _brushStrokeFinalized);
//    }
    
//    protected override void OnParentReplaced(RealtimeModel previousParent, RealtimeModel currentParent) {
//        _brushStrokeFinalizedProperty.UnsubscribeCallback();
//    }
    
//    protected override int WriteLength(StreamContext context) {
//        var length = 0;
//        length += _ribbonPointsProperty.WriteLength(context);
//        length += _brushTipPositionProperty.WriteLength(context);
//        length += _brushTipRotationProperty.WriteLength(context);
//        length += _brushStrokeFinalizedProperty.WriteLength(context);
//        return length;
//    }
    
//    protected override void Write(WriteStream stream, StreamContext context) {
//        var writes = false;
//        writes |= _ribbonPointsProperty.Write(stream, context);
//        writes |= _brushTipPositionProperty.Write(stream, context);
//        writes |= _brushTipRotationProperty.Write(stream, context);
//        writes |= _brushStrokeFinalizedProperty.Write(stream, context);
//        if (writes) InvalidateContextLength(context);
//    }
    
//    protected override void Read(ReadStream stream, StreamContext context) {
//        var anyPropertiesChanged = false;
//        while (stream.ReadNextPropertyID(out uint propertyID)) {
//            var changed = false;
//            switch (propertyID) {
//                case (uint) PropertyID.RibbonPoints: {
//                    changed = _ribbonPointsProperty.Read(stream, context);
//                    break;
//                }
//                case (uint) PropertyID.BrushTipPosition: {
//                    changed = _brushTipPositionProperty.Read(stream, context);
//                    break;
//                }
//                case (uint) PropertyID.BrushTipRotation: {
//                    changed = _brushTipRotationProperty.Read(stream, context);
//                    break;
//                }
//                case (uint) PropertyID.BrushStrokeFinalized: {
//                    changed = _brushStrokeFinalizedProperty.Read(stream, context);
//                    break;
//                }
//                default: {
//                    stream.SkipProperty();
//                    break;
//                }
//            }
//            anyPropertiesChanged |= changed;
//        }
//        if (anyPropertiesChanged) {
//            UpdateBackingFields();
//        }
//    }
    
//    private void UpdateBackingFields() {
//        _ribbonPoints = ribbonPoints;
//        _brushTipPosition = brushTipPosition;
//        _brushTipRotation = brushTipRotation;
//        _brushStrokeFinalized = brushStrokeFinalized;
//    }
    
//}
///* ----- End Normal Autogenerated Code ----- */
