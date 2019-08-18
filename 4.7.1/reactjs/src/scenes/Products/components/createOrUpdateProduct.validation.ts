import { L } from '../../../lib/abpUtility';

const rules = {
  description: [{ required: true, message: L('ThisFieldIsRequired') }],
  price: [{ required: true, message: L('ThisFieldIsRequired') }]
};

export default rules;
