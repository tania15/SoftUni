namespace _01.Loader
{
    using _01.Loader.Interfaces;
    using _01.Loader.Models;
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class Loader : IBuffer
    {
        private List<IEntity> entities;

        public Loader()
        {
            entities = new List<IEntity>();
        }
        public int EntitiesCount => entities.Count;

        public void Add(IEntity entity)
        {
            entities.Add(entity);
        }

        public void Clear()
        {
            //entities.Clear();

            while (entities.Count > 0)
            {
                entities.RemoveAt(entities.Count - 1);
            }
        }

        public bool Contains(IEntity entity)
        {
            //return entities.Contains(entity);

            for (int i = 0; i < entities.Count; i++)
            {
                if (entities[i].Id == entity.Id)
                {
                    return true;
                }
            }

            return false;
        }

        public IEntity Extract(int id)
        {
            IEntity entity = FindById(id);

            if (entity != null)
            {
                entities.Remove(entity);
            }

            return entity;
        }

        public IEntity Find(IEntity entity)
        {
            return FindByEntity(entity);
        }

        public List<IEntity> GetAll()
        {
            return new List<IEntity>(entities);
        }

        public IEnumerator<IEntity> GetEnumerator()
        {
            return entities.GetEnumerator();
        }

        public void RemoveSold()
        {
            for (int i = 0; i < entities.Count; i++)
            {
                if (entities[i].Status == BaseEntityStatus.Sold)
                {
                    entities.Remove(entities[i]);
                }
            }
        }

        public void Replace(IEntity oldEntity, IEntity newEntity)
        {
            //bool areExist = Contains(oldEntity) && Contains(newEntity);

            //if (areExist)
            //{
            int index = -1;

            for (int i = 0; i < entities.Count; i++)
            {
                if (entities[i].Id == oldEntity.Id)
                {
                    index = i;
                    break;
                }
            }

            if (index == -1)
            {
                throw new InvalidOperationException("Entity not found");
            }

            entities[index] = newEntity;
            //}
            //else
            //{
            //    throw new InvalidOperationException("Entity not found");
            //}
        }

        public List<IEntity> RetainAllFromTo(BaseEntityStatus lowerBound, BaseEntityStatus upperBound)
        {
            List<IEntity> result = new List<IEntity>();

            for (int i = 0; i < entities.Count; i++)
            {
                if (entities[i].Status >= lowerBound && entities[i].Status <= upperBound)
                {
                    result.Add(entities[i]);
                }
            }

            return result;
        }

        //public void Swap(IEntity first, IEntity second)
        //{
        //    //bool areExist = Contains(first) && Contains(second);

        //    //if (areExist)
        //    //{
        //    int indexFirst = -1;
        //    int indexSecond = -1;

        //    for (int i = 0; i < entities.Count; i++)
        //    {
        //        if (entities[i].Id == first.Id)
        //        {
        //            indexFirst = i;
        //        }

        //        if (entities[i].Id == second.Id)
        //        {
        //            indexSecond = i;
        //        }

        //        if (indexFirst >= 0 && indexSecond >= 0)
        //        {
        //            break;
        //        }
        //    }

        //    if (indexFirst == -1 || indexSecond == -1)
        //    {
        //        throw new InvalidOperationException("Entity not found");
        //    }

        //    IEntity temp = entities[indexFirst];
        //    entities[indexFirst] = entities[indexSecond];
        //    entities[indexSecond] = temp;
        //    //}
        //    //else
        //    //{            
        //    //throw new InvalidOperationException("Entity not found");
        //    //}
        //}

        public void Swap(IEntity first, IEntity second)
        {
            int firstEntityIndex = IndexOf(first.Id, 0, entities.Count);
            int secondEntityIndex = IndexOf(second.Id, 0, entities.Count);

            if (firstEntityIndex == -1 || secondEntityIndex == -1)
            {
                throw new InvalidOperationException("Entity not found");
            }

            IEntity temp = entities[firstEntityIndex];
            entities[firstEntityIndex] = entities[secondEntityIndex];
            entities[secondEntityIndex] = temp;
        }

        private int IndexOf(int searchedId, int start, int end)
        {
            int middle = (start + end) / 2;

            if (start >= end)
            {
                return -1;
            }

            if (start == end && end == entities.Count || end == -1)
            {
                return -1;
            }

            if (entities[middle].Id == searchedId)
            {
                return middle;
            }

            //int index = IndexOf(searchedId, start, middle - 1);

            //if (index == -1)
            //{
            //    index = IndexOf(searchedId, middle + 1, end - 1);
            //}

            if (entities[middle].Id > searchedId)
            {
                return IndexOf(searchedId, start, middle - 1);
            }
            else
            {
                return IndexOf(searchedId, middle + 1, end);
            }
        }
        public IEntity[] ToArray()
        {
            return entities.ToArray();
        }

        public void UpdateAll(BaseEntityStatus oldStatus, BaseEntityStatus newStatus)
        {
            for (int i = 0; i < entities.Count; i++)
            {
                if (entities[i].Status == oldStatus)
                {
                    entities[i].Status = newStatus;
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return entities.GetEnumerator();
        }

        private IEntity FindById(int id)
        {
            //IEntity entity = null;

            for (int i = 0; i < entities.Count; i++)
            {
                if (entities[i].Id == id)
                {
                    return entities[i];
                }
            }

            return null;
        }

        private IEntity FindByEntity(IEntity entity)
        {
            //IEntity entity = null;

            for (int i = 0; i < entities.Count; i++)
            {
                if (entities[i].Id == entity.Id)
                {
                    return entities[i];
                }
            }

            return null;
        }
    }
}
