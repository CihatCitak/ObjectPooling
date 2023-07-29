namespace ObjectPooling
{
    public interface IObjectPool<T>
    {
        public void Enqueue(T pooledObject);
        public T Dequeue();
    }
}