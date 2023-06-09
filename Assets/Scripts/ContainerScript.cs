using UnityEngine;

public class ContainerScript : MonoBehaviour//, IKitchenObejctParent
{
    [SerializeField] private KitchenObjectSO kitchenObjectSO;
    [SerializeField] private Transform counterTopPoint;

    private KitchenObject kitchenObject;

    public void Interact() {
        //if (kitchenObject == null) {
        //    Transform kitchenObjectTransform = Instantiate(
        //      kitchenObjectSO.prefab,
        //      counterTopPoint);
        //    kitchenObjectTransform
        //      .GetComponent<KitchenObject>().SetClearCounter(this);
        //} else {
        //    Debug.Log(kitchenObject.GetKitchenObjectParent());
        //}
    }

    public Transform GetKitchenObjectFollowTransform() {
        return counterTopPoint;
    }

    public void SetKitchenObject(KitchenObject kitchenObject) {
        this.kitchenObject = kitchenObject;
    }

    public KitchenObject GetKitchenObject() {
        return kitchenObject;
    }

    public void ClearKitchenObject() {
        kitchenObject = null;
    }

    public bool HasKitchenObject() {
        return kitchenObject != null;
    }
}
