using UnityEngine;

public interface ISkillable
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnSkillEffect(float damage, Vector3 hipoint);
}
