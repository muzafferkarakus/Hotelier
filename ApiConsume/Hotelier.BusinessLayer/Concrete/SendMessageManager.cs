﻿using Hotelier.BusinessLayer.Abstract;
using Hotelier.DataAccessLayer.Abstract;
using Hotelier.EntityLayer.Concrate;

namespace Hotelier.BusinessLayer.Concrete
{
    public class SendMessageManager : ISendMessageService
    {
        private readonly ISendMessageDal _sendMessageDal;

        public SendMessageManager(ISendMessageDal sendMessageDal)
        {
            _sendMessageDal = sendMessageDal;
        }

        public void TDelete(SendMessage t)
        {
            _sendMessageDal.Delete(t);
        }

        public SendMessage TGetById(int id)
        {
            return _sendMessageDal.GetById(id);
        }

        public List<SendMessage> TGetList()
        {
            return _sendMessageDal.GetList();
        }

        public int TGetSendMessageCount()
        {
            return _sendMessageDal.GetSendMessageCount();
        }

        public void TInsert(SendMessage t)
        {
            _sendMessageDal.Insert(t);
        }

        public void TUpdate(SendMessage t)
        {
            _sendMessageDal.Update(t);
        }
    }
}
