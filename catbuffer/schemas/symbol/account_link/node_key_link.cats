import "transaction.cats"

# Shared content between NodeKeyLinkTransaction and EmbeddedNodeKeyLinkTransaction.
inline struct NodeKeyLinkTransactionBody
	# Linked public key.
	linked_public_key = PublicKey

	# Account link action.
	link_action = LinkAction

# This transaction is required for all accounts willing to activate delegated harvesting.
#
# Announce a NodeKeyLinkTransaction to link an account with a public key used by TLS to create sessions.
struct NodeKeyLinkTransaction
	TRANSACTION_VERSION = make_const(uint8, 1)
	TRANSACTION_TYPE = make_const(TransactionType, NODE_KEY_LINK)

	inline Transaction
	inline NodeKeyLinkTransactionBody

# Embedded version of NodeKeyLinkTransaction.
struct EmbeddedNodeKeyLinkTransaction
	TRANSACTION_VERSION = make_const(uint8, 1)
	TRANSACTION_TYPE = make_const(TransactionType, NODE_KEY_LINK)

	inline EmbeddedTransaction
	inline NodeKeyLinkTransactionBody
