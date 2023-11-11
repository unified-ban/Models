using System.Collections.Generic;

namespace Unifiedban.Models
{
    public struct LogsAnswer
    {
        private List<OperationLog> OperationLog;
        private List<ActionLog> ActionLog;

        public LogsAnswer(List<OperationLog> operationLog, List<ActionLog> actionLog)
        {
            OperationLog = operationLog;
            ActionLog = actionLog;
        }
    }
}