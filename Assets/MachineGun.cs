using UnityEngine;

public class MachineGun : MonoBehaviour
{
    // fameFlower effect we enable to show the fire. when we shoot the target.
    [SerializeField] private GameObject flameFlowerEffect;

    // rotatingRod is the rod which will rotate to aim the target.
    [SerializeField] private Transform rotatingRod;

    // rotateSpeed is the speed at which the gun will rotate.
    [SerializeField] private float rotateSpeed = 10f;

    // range is the distance from the gun to the target.
    [SerializeField] private float range = 5f;

    // target is the object which we want to shoot.
    [SerializeField] private Transform target;

    private PlayerHealth _playerHealth;


    private void Update()
    {
        // if our target is null then return from the function. because we don't want to execute it further.
        if (target == null) return;

        // check if the player is not dead.
        if (_playerHealth == null)
        {
            _playerHealth = target.GetComponent<PlayerHealth>();
        }

        // if the player is dead then return from the function. because we don't want to execute it further.
        if (_playerHealth.IsDead)
        {
            flameFlowerEffect.SetActive(false);
            return;
        }

        // we check the distance between the target and the gun. if the distance is less than the range then we shoot the target.
        if (Vector3.Distance(transform.position, target.position) <= range)
        {
            // calculate the direction of the target from the gun.
            Vector3 direction = target.position - transform.position;

            // get the look Quaternion LookRotation from the direction.
            Quaternion lookRotation = Quaternion.LookRotation(direction);

            // we want to rotate our gun at y-Axis only. so calculate the rotation by Lerp function. so we can rotate smoothly per frame by the rotateSpeed.
            Vector3 rotation = Quaternion.Lerp(rotatingRod.rotation, lookRotation, Time.deltaTime * rotateSpeed).eulerAngles;

            // set the rotation only at y-Axis. so the gun will rotate only at y-Axis.
            rotatingRod.rotation = Quaternion.Euler(0f, rotation.y, 0f);

            // enable the flameFlowerEffect to show the fire.
            flameFlowerEffect.SetActive(true);
        }
        else
        {
            // if the distance is greater than the range then disable the flameFlowerEffect.
            flameFlowerEffect.SetActive(false);
        }
    }
}
