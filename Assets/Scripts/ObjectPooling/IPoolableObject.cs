namespace ObjectPooling
{
    public interface IPoolableObject<T>
    {
        public IObjectPool<T> PoolParent { get; set; }
    }
}