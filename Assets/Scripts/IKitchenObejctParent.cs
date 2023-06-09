using UnityEngine;

public interface IKitchenObejctParent {
    void ClearKitchenObject();
    KitchenObject GetKitchenObject();
    Transform GetKitchenObjectFollowTransform();
    bool HasKitchenObject();
    void SetKitchenObject(KitchenObject kitchenObject);
}